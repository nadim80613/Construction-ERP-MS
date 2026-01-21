namespace Construction_ERP__Management_System
{
    partial class UcProjectManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProjects
            // 
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Location = new System.Drawing.Point(320, 44);
            this.dgvProjects.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.RowHeadersWidth = 62;
            this.dgvProjects.RowTemplate.Height = 28;
            this.dgvProjects.Size = new System.Drawing.Size(357, 433);
            this.dgvProjects.TabIndex = 19;
            this.dgvProjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjects_CellClick);
            this.dgvProjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjects_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtEnd);
            this.groupBox1.Controls.Add(this.dtStart);
            this.groupBox1.Controls.Add(this.cmbStatus);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtLocation);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtCompanyID);
            this.groupBox1.Controls.Add(this.txtProjectID);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.btnView);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(314, 475);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Project Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(35, 391);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(56, 25);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(86, 432);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(53, 25);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSave.Location = new System.Drawing.Point(124, 391);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(53, 25);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyID.Location = new System.Drawing.Point(124, 86);
            this.txtCompanyID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.ReadOnly = true;
            this.txtCompanyID.Size = new System.Drawing.Size(186, 23);
            this.txtCompanyID.TabIndex = 9;
            // 
            // txtProjectID
            // 
            this.txtProjectID.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProjectID.Location = new System.Drawing.Point(124, 42);
            this.txtProjectID.Margin = new System.Windows.Forms.Padding(2);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.ReadOnly = true;
            this.txtProjectID.Size = new System.Drawing.Size(186, 23);
            this.txtProjectID.TabIndex = 8;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(124, 125);
            this.txtCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(186, 23);
            this.txtCode.TabIndex = 7;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnView.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnView.Location = new System.Drawing.Point(207, 391);
            this.btnView.Margin = new System.Windows.Forms.Padding(2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(53, 25);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "View ";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(165, 432);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 25);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Company ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Project ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project Code :";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l2.Location = new System.Drawing.Point(360, 15);
            this.l2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(77, 22);
            this.l2.TabIndex = 21;
            this.l2.Text = "Search :";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(441, 14);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 26);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(124, 166);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 23);
            this.txtName.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 166);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Project Name :";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocation.Location = new System.Drawing.Point(124, 204);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(186, 23);
            this.txtLocation.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Location :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 259);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Start :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(74, 308);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "End :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(60, 343);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Status :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(122, 337);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(125, 30);
            this.cmbStatus.TabIndex = 22;
            // 
            // dtStart
            // 
            this.dtStart.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStart.Location = new System.Drawing.Point(122, 251);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(192, 29);
            this.dtStart.TabIndex = 23;
            // 
            // dtEnd
            // 
            this.dtEnd.CalendarFont = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEnd.Location = new System.Drawing.Point(122, 300);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(191, 29);
            this.dtEnd.TabIndex = 24;
            // 
            // UcProjectManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvProjects);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcProjectManagement";
            this.Size = new System.Drawing.Size(682, 481);
            this.Load += new System.EventHandler(this.UcProjectManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
    }
}
