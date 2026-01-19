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
            this.Signupmainpanal = new System.Windows.Forms.Panel();
            this.grpCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(424, 56);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(413, 41);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Construction ERP System";
            // 
            // cmbSignUpAs
            // 
            this.cmbSignUpAs.FormattingEnabled = true;
            this.cmbSignUpAs.Location = new System.Drawing.Point(167, 27);
            this.cmbSignUpAs.Name = "cmbSignUpAs";
            this.cmbSignUpAs.Size = new System.Drawing.Size(359, 40);
            this.cmbSignUpAs.TabIndex = 4;
            // 
            // grpCompany
            // 
            this.grpCompany.Controls.Add(this.cmbSignUpAs);
            this.grpCompany.Location = new System.Drawing.Point(80, 112);
            this.grpCompany.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grpCompany.Name = "grpCompany";
            this.grpCompany.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grpCompany.Size = new System.Drawing.Size(946, 86);
            this.grpCompany.TabIndex = 2;
            this.grpCompany.TabStop = false;
            this.grpCompany.Text = "SignUp as ";
            // 
            // Signupmainpanal
            // 
            this.Signupmainpanal.Location = new System.Drawing.Point(80, 221);
            this.Signupmainpanal.Name = "Signupmainpanal";
            this.Signupmainpanal.Size = new System.Drawing.Size(946, 429);
            this.Signupmainpanal.TabIndex = 3;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1114, 672);
            this.Controls.Add(this.Signupmainpanal);
            this.Controls.Add(this.grpCompany);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmSignUp";
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
        private System.Windows.Forms.Panel Signupmainpanal;
    }
}