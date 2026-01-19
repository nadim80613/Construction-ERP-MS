using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Construction_ERP__Management_System
{
    public static class DbConnection
    {
        private static readonly string dbFolder =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                         "ConstructionERP");

        private static readonly string dbName = "ConstructionERP_DB";
        private static readonly string dbFilePath = Path.Combine(dbFolder, $"{dbName}.mdf");
        private static readonly string logFilePath = Path.Combine(dbFolder, $"{dbName}_log.ldf");

        private static readonly string connectionString =
            $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbFilePath};Integrated Security=True;Connect Timeout=30;";

        private static bool _schemaEnsured = false;
        private static readonly object _schemaLock = new object();

        public static SqlConnection GetConnection()
        {
            Directory.CreateDirectory(dbFolder);

            if (!File.Exists(dbFilePath))
            {
                CreateDatabase(dbFilePath, logFilePath);
            }

            EnsureSchemaOnce();

            return new SqlConnection(connectionString);
        }

        private static void CreateDatabase(string mdfPath, string ldfPath)
        {
            const string masterConn =
                @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;";

            string sql = $@"
CREATE DATABASE [{dbName}]
ON PRIMARY
(
    NAME = N'{dbName}',
    FILENAME = N'{mdfPath}'
)
LOG ON
(
    NAME = N'{dbName}_log',
    FILENAME = N'{ldfPath}'
);";

            try
            {
                using (SqlConnection conn = new SqlConnection(masterConn))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database creation failed: " + ex.Message);
            }
        }

        private static void EnsureSchemaOnce()
        {
            lock (_schemaLock)
            {
                if (_schemaEnsured) return;

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlTransaction tx = conn.BeginTransaction())
                        {
                            ExecuteNonQuery(conn, tx, GetSchemaSql());
                            tx.Commit();
                        }
                    }

                    _schemaEnsured = true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Schema creation failed: " + ex.Message);
                }
            }
        }

        private static void ExecuteNonQuery(SqlConnection conn, SqlTransaction tx, string sql)
        {
            using (SqlCommand cmd = new SqlCommand(sql, conn, tx))
            {
                cmd.CommandTimeout = 60;
                cmd.ExecuteNonQuery();
            }
        }

        private static string GetSchemaSql()
        {
            return @"
-- =========================
-- Companies
-- =========================
IF OBJECT_ID(N'dbo.Companies', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[Companies] (
        [CompanyID] INT IDENTITY (1, 1) NOT NULL,
        [Name]      NVARCHAR (200) NOT NULL,
        [Address]   NVARCHAR (300) NOT NULL,
        [TaxID]     NVARCHAR (50)  NOT NULL,
        [CreatedAt] DATETIME       CONSTRAINT DF_Companies_CreatedAt DEFAULT (GETDATE()) NOT NULL,
        CONSTRAINT PK_Companies PRIMARY KEY CLUSTERED ([CompanyID] ASC)
    );
END;

-- =========================
-- Users
-- =========================
IF OBJECT_ID(N'dbo.Users', N'U') IS NULL
BEGIN
    CREATE TABLE [dbo].[Users] (
        [UserID]       INT            IDENTITY (1, 1) NOT NULL,
        [CompanyID]    INT            NOT NULL,
        [Name]         NVARCHAR (150) NOT NULL,
        [Email]        NVARCHAR (150) NOT NULL,
        [PasswordHash] NVARCHAR (256) NOT NULL,
        [Role]         NVARCHAR (50)  NOT NULL,
        [Status]       NVARCHAR (50)  NOT NULL,
        [CreatedAt]    DATETIME       CONSTRAINT DF_Users_CreatedAt DEFAULT (GETDATE()) NOT NULL,
        CONSTRAINT PK_Users PRIMARY KEY CLUSTERED ([UserID] ASC),
        CONSTRAINT UQ_Users_Email UNIQUE NONCLUSTERED ([Email] ASC),
        CONSTRAINT FK_Users_Companies FOREIGN KEY ([CompanyID]) REFERENCES [dbo].[Companies] ([CompanyID])
    );
END;

-- =========================
-- Projects
-- =========================
IF OBJECT_ID(N'dbo.Projects', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Projects
    (
        ProjectID   INT IDENTITY(1,1) NOT NULL,
        CompanyID   INT NOT NULL,
        ProjectCode NVARCHAR(50) NOT NULL,
        Name        NVARCHAR(200) NOT NULL,
        Location    NVARCHAR(200) NULL,
        StartDate   DATE NULL,
        EndDate     DATE NULL,
        Status      NVARCHAR(50) NOT NULL,
        CreatedAt   DATETIME CONSTRAINT DF_Projects_CreatedAt DEFAULT (GETDATE()) NOT NULL,
        CONSTRAINT PK_Projects PRIMARY KEY CLUSTERED (ProjectID),
        CONSTRAINT FK_Projects_Companies FOREIGN KEY (CompanyID) REFERENCES dbo.Companies(CompanyID)
    );

    CREATE UNIQUE INDEX UX_Projects_Company_ProjectCode ON dbo.Projects(CompanyID, ProjectCode);
END;

-- =========================
-- WBSNode
-- =========================
IF OBJECT_ID(N'dbo.WBSNode', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.WBSNode
    (
        WBSID        INT IDENTITY(1,1) NOT NULL,
        ProjectID    INT NOT NULL,
        ParentWBSID  INT NULL,
        WBSCode      NVARCHAR(50) NOT NULL,
        Title        NVARCHAR(200) NOT NULL,
        [Level]      INT NOT NULL,
        CONSTRAINT PK_WBSNode PRIMARY KEY CLUSTERED (WBSID),
        CONSTRAINT FK_WBSNode_Projects FOREIGN KEY (ProjectID) REFERENCES dbo.Projects(ProjectID),
        CONSTRAINT FK_WBSNode_Parent FOREIGN KEY (ParentWBSID) REFERENCES dbo.WBSNode(WBSID)
    );

    CREATE INDEX IX_WBSNode_Project ON dbo.WBSNode(ProjectID);
END;

-- =========================
-- CostCodes
-- =========================
IF OBJECT_ID(N'dbo.CostCodes', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.CostCodes
    (
        CostCodeID    INT IDENTITY(1,1) NOT NULL,
        ProjectID     INT NOT NULL,
        Code          NVARCHAR(50) NOT NULL,
        [Description] NVARCHAR(300) NULL,
        CostType      NVARCHAR(10) NOT NULL,
        IsActive      BIT CONSTRAINT DF_CostCodes_IsActive DEFAULT (1) NOT NULL,
        CONSTRAINT PK_CostCodes PRIMARY KEY CLUSTERED (CostCodeID),
        CONSTRAINT FK_CostCodes_Projects FOREIGN KEY (ProjectID) REFERENCES dbo.Projects(ProjectID),
        CONSTRAINT CK_CostCodes_CostType CHECK (CostType IN (N'Labor', N'Mat', N'Sub', N'Equip'))
    );

    CREATE UNIQUE INDEX UX_CostCodes_Project_Code ON dbo.CostCodes(ProjectID, Code);
END;

-- =========================
-- BudgetRevisions
-- =========================
IF OBJECT_ID(N'dbo.BudgetRevisions', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.BudgetRevisions
    (
        BudgetRevID  INT IDENTITY(1,1) NOT NULL,
        ProjectID    INT NOT NULL,
        RevisionNo   INT NOT NULL,
        [Type]       NVARCHAR(20) NOT NULL,
        [Status]     NVARCHAR(20) NOT NULL,
        CreatedBy    INT NOT NULL,
        CreatedAt    DATETIME CONSTRAINT DF_BudgetRevisions_CreatedAt DEFAULT (GETDATE()) NOT NULL,
        ApprovedBy   INT NULL,
        ApprovedAt   DATETIME NULL,
        CONSTRAINT PK_BudgetRevisions PRIMARY KEY CLUSTERED (BudgetRevID),
        CONSTRAINT FK_BudgetRevisions_Projects FOREIGN KEY (ProjectID) REFERENCES dbo.Projects(ProjectID),
        CONSTRAINT FK_BudgetRevisions_CreatedBy FOREIGN KEY (CreatedBy) REFERENCES dbo.Users(UserID),
        CONSTRAINT FK_BudgetRevisions_ApprovedBy FOREIGN KEY (ApprovedBy) REFERENCES dbo.Users(UserID),
        CONSTRAINT CK_BudgetRevisions_Type CHECK ([Type] IN (N'Baseline', N'Revision')),
        CONSTRAINT CK_BudgetRevisions_Status CHECK ([Status] IN (N'Draft', N'Approved', N'Locked'))
    );

    CREATE UNIQUE INDEX UX_BudgetRevisions_Project_RevisionNo ON dbo.BudgetRevisions(ProjectID, RevisionNo);
END;

-- =========================
-- BudgetLines
-- =========================
IF OBJECT_ID(N'dbo.BudgetLines', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.BudgetLines
    (
        BudgetLineID INT IDENTITY(1,1) NOT NULL,
        BudgetRevID  INT NOT NULL,
        WBSID        INT NOT NULL,
        CostCodeID   INT NOT NULL,
        Amount       DECIMAL(18,2) NOT NULL,
        Notes        NVARCHAR(500) NULL,
        CONSTRAINT PK_BudgetLines PRIMARY KEY CLUSTERED (BudgetLineID),
        CONSTRAINT FK_BudgetLines_BudgetRevisions FOREIGN KEY (BudgetRevID) REFERENCES dbo.BudgetRevisions(BudgetRevID),
        CONSTRAINT FK_BudgetLines_WBSNode FOREIGN KEY (WBSID) REFERENCES dbo.WBSNode(WBSID),
        CONSTRAINT FK_BudgetLines_CostCodes FOREIGN KEY (CostCodeID) REFERENCES dbo.CostCodes(CostCodeID)
    );

    CREATE INDEX IX_BudgetLines_BudgetRev ON dbo.BudgetLines(BudgetRevID);
END;

-- =========================
-- Vendors
-- =========================
IF OBJECT_ID(N'dbo.Vendors', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Vendors
    (
        VendorID   INT IDENTITY(1,1) NOT NULL,
        CompanyID  INT NOT NULL,
        Name       NVARCHAR(200) NOT NULL,
        [Type]     NVARCHAR(20) NOT NULL,
        Phone      NVARCHAR(50) NULL,
        Email      NVARCHAR(150) NULL,
        [Status]   NVARCHAR(50) NOT NULL,
        CreatedAt  DATETIME CONSTRAINT DF_Vendors_CreatedAt DEFAULT (GETDATE()) NOT NULL,
        CONSTRAINT PK_Vendors PRIMARY KEY CLUSTERED (VendorID),
        CONSTRAINT FK_Vendors_Companies FOREIGN KEY (CompanyID) REFERENCES dbo.Companies(CompanyID),
        CONSTRAINT CK_Vendors_Type CHECK ([Type] IN (N'Subcontractor', N'Supplier', N'Rental'))
    );

    CREATE INDEX IX_Vendors_Company ON dbo.Vendors(CompanyID);
END;

-- =========================
-- Commitments
-- =========================
IF OBJECT_ID(N'dbo.Commitments', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Commitments
    (
        CommitmentID   INT IDENTITY(1,1) NOT NULL,
        ProjectID      INT NOT NULL,
        VendorID       INT NOT NULL,
        [Type]         NVARCHAR(20) NOT NULL,
        CommitmentNo   NVARCHAR(50) NOT NULL,
        [Status]       NVARCHAR(20) NOT NULL,
        RetainageRate  DECIMAL(5,2) CONSTRAINT DF_Commitments_RetainageRate DEFAULT (0) NOT NULL,
        CreatedAt      DATETIME CONSTRAINT DF_Commitments_CreatedAt DEFAULT (GETDATE()) NOT NULL,
        CONSTRAINT PK_Commitments PRIMARY KEY CLUSTERED (CommitmentID),
        CONSTRAINT FK_Commitments_Projects FOREIGN KEY (ProjectID) REFERENCES dbo.Projects(ProjectID),
        CONSTRAINT FK_Commitments_Vendors FOREIGN KEY (VendorID) REFERENCES dbo.Vendors(VendorID),
        CONSTRAINT CK_Commitments_Type CHECK ([Type] IN (N'Subcontract', N'PO', N'Rental')),
        CONSTRAINT CK_Commitments_Status CHECK ([Status] IN (N'Draft', N'Active', N'Closed')),
        CONSTRAINT CK_Commitments_RetainageRate CHECK (RetainageRate >= 0 AND RetainageRate <= 100)
    );

    CREATE UNIQUE INDEX UX_Commitments_Project_CommitmentNo ON dbo.Commitments(ProjectID, CommitmentNo);
END;

-- =========================
-- CommitmentLines
-- =========================
IF OBJECT_ID(N'dbo.CommitmentLines', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.CommitmentLines
    (
        CommitmentLineID INT IDENTITY(1,1) NOT NULL,
        CommitmentID     INT NOT NULL,
        WBSID            INT NOT NULL,
        CostCodeID       INT NOT NULL,
        CommittedAmount  DECIMAL(18,2) NOT NULL,
        CONSTRAINT PK_CommitmentLines PRIMARY KEY CLUSTERED (CommitmentLineID),
        CONSTRAINT FK_CommitmentLines_Commitments FOREIGN KEY (CommitmentID) REFERENCES dbo.Commitments(CommitmentID),
        CONSTRAINT FK_CommitmentLines_WBSNode FOREIGN KEY (WBSID) REFERENCES dbo.WBSNode(WBSID),
        CONSTRAINT FK_CommitmentLines_CostCodes FOREIGN KEY (CostCodeID) REFERENCES dbo.CostCodes(CostCodeID)
    );

    CREATE INDEX IX_CommitmentLines_Commitment ON dbo.CommitmentLines(CommitmentID);
END;

-- =========================
-- JobCostTxns
-- =========================
IF OBJECT_ID(N'dbo.JobCostTxns', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.JobCostTxns
    (
        JobCostTxnID  INT IDENTITY(1,1) NOT NULL,
        ProjectID     INT NOT NULL,
        [Date]        DATE NOT NULL,
        SourceType    NVARCHAR(20) NOT NULL,
        SourceID      NVARCHAR(50) NULL,
        WBSID         INT NOT NULL,
        CostCodeID    INT NOT NULL,
        Amount        DECIMAL(18,2) NOT NULL,
        [Description] NVARCHAR(500) NULL,
        CreatedAt     DATETIME CONSTRAINT DF_JobCostTxns_CreatedAt DEFAULT (GETDATE()) NOT NULL,
        CONSTRAINT PK_JobCostTxns PRIMARY KEY CLUSTERED (JobCostTxnID),
        CONSTRAINT FK_JobCostTxns_Projects FOREIGN KEY (ProjectID) REFERENCES dbo.Projects(ProjectID),
        CONSTRAINT FK_JobCostTxns_WBSNode FOREIGN KEY (WBSID) REFERENCES dbo.WBSNode(WBSID),
        CONSTRAINT FK_JobCostTxns_CostCodes FOREIGN KEY (CostCodeID) REFERENCES dbo.CostCodes(CostCodeID),
        CONSTRAINT CK_JobCostTxns_SourceType CHECK (SourceType IN (N'AP', N'Payroll', N'Equip', N'Mat'))
    );

    CREATE INDEX IX_JobCostTxns_Project_Date ON dbo.JobCostTxns(ProjectID, [Date]);
END;

-- =========================
-- Invoices
-- =========================
IF OBJECT_ID(N'dbo.Invoices', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Invoices
    (
        InvoiceID          INT IDENTITY(1,1) NOT NULL,
        ProjectID          INT NOT NULL,
        InvoiceNo          NVARCHAR(50) NOT NULL,
        BillingType        NVARCHAR(20) NOT NULL,
        PeriodStart        DATE NULL,
        PeriodEnd          DATE NULL,
        [Status]           NVARCHAR(20) NOT NULL,
        RetainageWithheld  DECIMAL(18,2) CONSTRAINT DF_Invoices_RetainageWithheld DEFAULT (0) NOT NULL,
        CreatedAt          DATETIME CONSTRAINT DF_Invoices_CreatedAt DEFAULT (GETDATE()) NOT NULL,
        CONSTRAINT PK_Invoices PRIMARY KEY CLUSTERED (InvoiceID),
        CONSTRAINT FK_Invoices_Projects FOREIGN KEY (ProjectID) REFERENCES dbo.Projects(ProjectID),
        CONSTRAINT CK_Invoices_BillingType CHECK (BillingType IN (N'AIA', N'T&M', N'Milestone')),
        CONSTRAINT CK_Invoices_Status CHECK ([Status] IN (N'Draft', N'Sent', N'Paid'))
    );

    CREATE UNIQUE INDEX UX_Invoices_Project_InvoiceNo ON dbo.Invoices(ProjectID, InvoiceNo);
END;

-- =========================
-- InvoiceLines
-- =========================
IF OBJECT_ID(N'dbo.InvoiceLines', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.InvoiceLines
    (
        InvoiceLineID      INT IDENTITY(1,1) NOT NULL,
        InvoiceID          INT NOT NULL,
        WBSID              INT NOT NULL,
        CostCodeID         INT NULL,
        AmountThisPeriod   DECIMAL(18,2) NOT NULL,
        PercentComplete    DECIMAL(5,2) NULL,
        CONSTRAINT PK_InvoiceLines PRIMARY KEY CLUSTERED (InvoiceLineID),
        CONSTRAINT FK_InvoiceLines_Invoices FOREIGN KEY (InvoiceID) REFERENCES dbo.Invoices(InvoiceID),
        CONSTRAINT FK_InvoiceLines_WBSNode FOREIGN KEY (WBSID) REFERENCES dbo.WBSNode(WBSID),
        CONSTRAINT FK_InvoiceLines_CostCodes FOREIGN KEY (CostCodeID) REFERENCES dbo.CostCodes(CostCodeID),
        CONSTRAINT CK_InvoiceLines_PercentComplete CHECK (PercentComplete IS NULL OR (PercentComplete >= 0 AND PercentComplete <= 100))
    );

    CREATE INDEX IX_InvoiceLines_Invoice ON dbo.InvoiceLines(InvoiceID);
END;

-- =========================
-- WIPSnapshots
-- =========================
IF OBJECT_ID(N'dbo.WIPSnapshots', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.WIPSnapshots
    (
        WIPID                INT IDENTITY(1,1) NOT NULL,
        ProjectID            INT NOT NULL,
        PeriodEnd            DATE NOT NULL,
        ContractValue        DECIMAL(18,2) NOT NULL,
        CostsToDate          DECIMAL(18,2) NOT NULL,
        EstCostAtCompletion  DECIMAL(18,2) NOT NULL,
        PercentComplete      DECIMAL(5,2) NOT NULL,
        EarnedRevenueToDate  DECIMAL(18,2) NOT NULL,
        BillingsToDate       DECIMAL(18,2) NOT NULL,
        OverUnderBilling     DECIMAL(18,2) NOT NULL,
        CreatedAt            DATETIME CONSTRAINT DF_WIPSnapshots_CreatedAt DEFAULT (GETDATE()) NOT NULL,
        CONSTRAINT PK_WIPSnapshots PRIMARY KEY CLUSTERED (WIPID),
        CONSTRAINT FK_WIPSnapshots_Projects FOREIGN KEY (ProjectID) REFERENCES dbo.Projects(ProjectID),
        CONSTRAINT CK_WIPSnapshots_PercentComplete CHECK (PercentComplete >= 0 AND PercentComplete <= 100)
    );

    CREATE UNIQUE INDEX UX_WIPSnapshots_Project_PeriodEnd ON dbo.WIPSnapshots(ProjectID, PeriodEnd);
END;

-- =========================
-- SEED: Ensure CompanyID = 1 exists
-- =========================
IF NOT EXISTS (SELECT 1 FROM dbo.Companies WHERE CompanyID = 1)
BEGIN
    SET IDENTITY_INSERT dbo.Companies ON;

    INSERT INTO dbo.Companies (CompanyID, [Name], [Address], TaxID, CreatedAt)
    VALUES (1, N'System Company', N'System', N'SYSTEM', GETDATE());

    SET IDENTITY_INSERT dbo.Companies OFF;
END;

-- =========================
-- SEED: Super Admin user
-- role: Super Admin
-- username/email: admin@system.com
-- password hash: pmWkWSBCL51Bfkhn79xPuKBKHz//H6B+mY6G9/eieuM=
-- company id: 1
-- =========================
IF NOT EXISTS (SELECT 1 FROM dbo.Users WHERE Email = N'admin@system.com')
BEGIN
    INSERT INTO dbo.Users (CompanyID, [Name], Email, PasswordHash, [Role], [Status], CreatedAt)
    VALUES (1, N'System Admin', N'admin@system.com',
            N'pmWkWSBCL51Bfkhn79xPuKBKHz//H6B+mY6G9/eieuM=',
            N'Super Admin', N'Active', GETDATE());
END;
";
        }
    }
}
