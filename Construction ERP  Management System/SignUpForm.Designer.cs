namespace Construction_ERP__Management_System
{
    partial class frmSignUp
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbSignUpAs = new System.Windows.Forms.ComboBox();
            this.grpCompany = new System.Windows.Forms.GroupBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(329, 26);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(413, 41);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Construction ERP System";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // cmbSignUpAs
            // 
            this.cmbSignUpAs.FormattingEnabled = true;
            this.cmbSignUpAs.Location = new System.Drawing.Point(167, 27);
            this.cmbSignUpAs.Name = "cmbSignUpAs";
            this.cmbSignUpAs.Size = new System.Drawing.Size(359, 40);
            this.cmbSignUpAs.TabIndex = 4;
            this.cmbSignUpAs.SelectionChangeCommitted += new System.EventHandler(this.cmbSignUpAs_SelectionChangeCommitted);
            // 
            // grpCompany
            // 
            this.grpCompany.Controls.Add(this.cmbSignUpAs);
            this.grpCompany.Location = new System.Drawing.Point(63, 72);
            this.grpCompany.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grpCompany.Name = "grpCompany";
            this.grpCompany.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grpCompany.Size = new System.Drawing.Size(946, 73);
            this.grpCompany.TabIndex = 2;
            this.grpCompany.TabStop = false;
            this.grpCompany.Text = "SignUp as ";
            // 
            // panelMain
            // 
            this.panelMain.Location = new System.Drawing.Point(63, 153);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(946, 429);
            this.panelMain.TabIndex = 3;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(921, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 39);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1064, 587);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.grpCompany);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.frmSignUp_Load);
            this.grpCompany.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbSignUpAs;
        private System.Windows.Forms.GroupBox grpCompany;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnBack;
    }
}