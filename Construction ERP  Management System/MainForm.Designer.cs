namespace Construction_ERP__Management_System
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnInvoices = new System.Windows.Forms.Button();
            this.btnVendor = new System.Windows.Forms.Button();
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnCompanySetup = new System.Windows.Forms.Button();
            this.btnDasboard = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelMain);
            this.splitContainer1.Panel2.Controls.Add(this.pnlTop);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1424, 846);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnInvoices);
            this.panel2.Controls.Add(this.btnVendor);
            this.panel2.Controls.Add(this.btnProjects);
            this.panel2.Controls.Add(this.btnUserManagement);
            this.panel2.Controls.Add(this.btnCompanySetup);
            this.panel2.Controls.Add(this.btnDasboard);
            this.panel2.Location = new System.Drawing.Point(4, 128);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 718);
            this.panel2.TabIndex = 2;
            // 
            // btnInvoices
            // 
            this.btnInvoices.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnInvoices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInvoices.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoices.Location = new System.Drawing.Point(72, 425);
            this.btnInvoices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInvoices.Name = "btnInvoices";
            this.btnInvoices.Size = new System.Drawing.Size(272, 54);
            this.btnInvoices.TabIndex = 26;
            this.btnInvoices.Text = "Invoices";
            this.btnInvoices.UseVisualStyleBackColor = false;
            // 
            // btnVendor
            // 
            this.btnVendor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnVendor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVendor.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVendor.Location = new System.Drawing.Point(72, 346);
            this.btnVendor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVendor.Name = "btnVendor";
            this.btnVendor.Size = new System.Drawing.Size(272, 54);
            this.btnVendor.TabIndex = 24;
            this.btnVendor.Text = "Vendors";
            this.btnVendor.UseVisualStyleBackColor = false;
            this.btnVendor.Click += new System.EventHandler(this.btnVendor_Click);
            // 
            // btnProjects
            // 
            this.btnProjects.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnProjects.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProjects.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjects.Location = new System.Drawing.Point(72, 269);
            this.btnProjects.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Size = new System.Drawing.Size(272, 54);
            this.btnProjects.TabIndex = 23;
            this.btnProjects.Text = "Projects";
            this.btnProjects.UseVisualStyleBackColor = false;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUserManagement.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserManagement.Location = new System.Drawing.Point(72, 192);
            this.btnUserManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(272, 54);
            this.btnUserManagement.TabIndex = 22;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = false;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnCompanySetup
            // 
            this.btnCompanySetup.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCompanySetup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompanySetup.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompanySetup.Location = new System.Drawing.Point(72, 108);
            this.btnCompanySetup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCompanySetup.Name = "btnCompanySetup";
            this.btnCompanySetup.Size = new System.Drawing.Size(272, 54);
            this.btnCompanySetup.TabIndex = 21;
            this.btnCompanySetup.Text = "Company Setup";
            this.btnCompanySetup.UseVisualStyleBackColor = false;
            this.btnCompanySetup.Click += new System.EventHandler(this.btnCompanySetup_Click);
            // 
            // btnDasboard
            // 
            this.btnDasboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDasboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDasboard.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDasboard.Location = new System.Drawing.Point(0, 20);
            this.btnDasboard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDasboard.Name = "btnDasboard";
            this.btnDasboard.Size = new System.Drawing.Size(387, 54);
            this.btnDasboard.TabIndex = 20;
            this.btnDasboard.Text = "Dashboard";
            this.btnDasboard.UseVisualStyleBackColor = false;
            this.btnDasboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 92);
            this.panel1.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(36, 26);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(305, 41);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Construction ERP ";
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Teal;
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.btnBack);
            this.pnlTop.Controls.Add(this.lblUserInfo);
            this.pnlTop.ForeColor = System.Drawing.Color.White;
            this.pnlTop.Location = new System.Drawing.Point(4, 5);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1023, 92);
            this.pnlTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(876, 20);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 43);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Log Out";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.ForeColor = System.Drawing.Color.White;
            this.lblUserInfo.Location = new System.Drawing.Point(324, 26);
            this.lblUserInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(523, 26);
            this.lblUserInfo.TabIndex = 6;
            this.lblUserInfo.Text = "User: ..............| Role: ..............| Company:...............";
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(4, 106);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1023, 740);
            this.panelMain.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 846);
            this.Controls.Add(this.splitContainer1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Construction ERP - DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDasboard;
        private System.Windows.Forms.Button btnInvoices;
        private System.Windows.Forms.Button btnVendor;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnCompanySetup;
        private System.Windows.Forms.Panel panelMain;
    }
}