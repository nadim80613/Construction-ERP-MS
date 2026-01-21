namespace Construction_ERP__Management_System
{
    partial class frmCompanySetup
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
            this.grpCompany = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtTaxID = new System.Windows.Forms.TextBox();
            this.lblTaxID = new System.Windows.Forms.Label();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.dgvCompanies = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Gray;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpCompany);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel2.Controls.Add(this.dgvCompanies);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(667, 445);
            this.splitContainer1.SplitterDistance = 259;
            this.splitContainer1.TabIndex = 0;
            // 
            // grpCompany
            // 
            this.grpCompany.BackColor = System.Drawing.Color.White;
            this.grpCompany.Controls.Add(this.btnShowAll);
            this.grpCompany.Controls.Add(this.btnRefresh);
            this.grpCompany.Controls.Add(this.btnDelete);
            this.grpCompany.Controls.Add(this.btnClear);
            this.grpCompany.Controls.Add(this.btnUpdate);
            this.grpCompany.Controls.Add(this.btnSave);
            this.grpCompany.Controls.Add(this.txtTaxID);
            this.grpCompany.Controls.Add(this.lblTaxID);
            this.grpCompany.Controls.Add(this.txtCompanyAddress);
            this.grpCompany.Controls.Add(this.lblCompanyAddress);
            this.grpCompany.Controls.Add(this.txtCompanyName);
            this.grpCompany.Controls.Add(this.lblCompanyName);
            this.grpCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCompany.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCompany.Location = new System.Drawing.Point(0, 0);
            this.grpCompany.Name = "grpCompany";
            this.grpCompany.Size = new System.Drawing.Size(259, 445);
            this.grpCompany.TabIndex = 0;
            this.grpCompany.TabStop = false;
            this.grpCompany.Text = "Company Info";
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnShowAll.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.White;
            this.btnShowAll.Location = new System.Drawing.Point(15, 262);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(59, 25);
            this.btnShowAll.TabIndex = 17;
            this.btnShowAll.Text = "ShowAll";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(96, 262);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(59, 25);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(178, 212);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(59, 25);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(15, 212);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 25);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(96, 212);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(59, 25);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(178, 170);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 25);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTaxID
            // 
            this.txtTaxID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxID.Location = new System.Drawing.Point(87, 116);
            this.txtTaxID.Name = "txtTaxID";
            this.txtTaxID.Size = new System.Drawing.Size(154, 23);
            this.txtTaxID.TabIndex = 10;
            // 
            // lblTaxID
            // 
            this.lblTaxID.AutoSize = true;
            this.lblTaxID.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxID.Location = new System.Drawing.Point(17, 116);
            this.lblTaxID.Name = "lblTaxID";
            this.lblTaxID.Size = new System.Drawing.Size(58, 17);
            this.lblTaxID.TabIndex = 9;
            this.lblTaxID.Text = "TaxID :";
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyAddress.Location = new System.Drawing.Point(87, 83);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(154, 23);
            this.txtCompanyAddress.TabIndex = 8;
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyAddress.Location = new System.Drawing.Point(11, 83);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(72, 17);
            this.lblCompanyAddress.TabIndex = 7;
            this.lblCompanyAddress.Text = "Address :";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(87, 52);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(154, 23);
            this.txtCompanyName.TabIndex = 6;
            this.txtCompanyName.TextChanged += new System.EventHandler(this.txtFullName_TextChanged);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(28, 53);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(55, 17);
            this.lblCompanyName.TabIndex = 5;
            this.lblCompanyName.Text = "Name :";
            this.lblCompanyName.Click += new System.EventHandler(this.lblFullName_Click);
            // 
            // dgvCompanies
            // 
            this.dgvCompanies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanies.Location = new System.Drawing.Point(1, 37);
            this.dgvCompanies.Name = "dgvCompanies";
            this.dgvCompanies.RowHeadersWidth = 62;
            this.dgvCompanies.Size = new System.Drawing.Size(400, 467);
            this.dgvCompanies.TabIndex = 0;
            this.dgvCompanies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCompanies_CellContentClick);
            this.dgvCompanies.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCompanies_CellMouseClick);
            // 
            // frmCompanySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(667, 445);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmCompanySetup";
            this.Text = "CompanySetupForm";
            this.Load += new System.EventHandler(this.frmCompanySetup_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpCompany.ResumeLayout(false);
            this.grpCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpCompany;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtTaxID;
        private System.Windows.Forms.Label lblTaxID;
        private System.Windows.Forms.TextBox txtCompanyAddress;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvCompanies;
        private System.Windows.Forms.Button btnShowAll;
    }
}