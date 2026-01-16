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
            this.grpCompany = new System.Windows.Forms.GroupBox();
            this.lblCompanyID = new System.Windows.Forms.Label();
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtCompanyID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grpCompany.SuspendLayout();
            this.grpUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(424, 56);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(277, 26);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Construction ERP System";
            // 
            // grpCompany
            // 
            this.grpCompany.Controls.Add(this.txtCompanyID);
            this.grpCompany.Controls.Add(this.lblCompanyID);
            this.grpCompany.Location = new System.Drawing.Point(152, 112);
            this.grpCompany.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grpCompany.Name = "grpCompany";
            this.grpCompany.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grpCompany.Size = new System.Drawing.Size(874, 86);
            this.grpCompany.TabIndex = 2;
            this.grpCompany.TabStop = false;
            this.grpCompany.Text = "Company Information";
            // 
            // lblCompanyID
            // 
            this.lblCompanyID.AutoSize = true;
            this.lblCompanyID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyID.Location = new System.Drawing.Point(153, 44);
            this.lblCompanyID.Name = "lblCompanyID";
            this.lblCompanyID.Size = new System.Drawing.Size(125, 19);
            this.lblCompanyID.TabIndex = 3;
            this.lblCompanyID.Text = "Company Name :";
            // 
            // grpUser
            // 
            this.grpUser.Controls.Add(this.textBox2);
            this.grpUser.Controls.Add(this.label1);
            this.grpUser.Controls.Add(this.comboBox1);
            this.grpUser.Controls.Add(this.chkShowPassword);
            this.grpUser.Controls.Add(this.txtConfirmPassword);
            this.grpUser.Controls.Add(this.lblConfirmPassword);
            this.grpUser.Controls.Add(this.txtPassword);
            this.grpUser.Controls.Add(this.lblPassword);
            this.grpUser.Controls.Add(this.txtEmail);
            this.grpUser.Controls.Add(this.lblEmail);
            this.grpUser.Controls.Add(this.txtFullName);
            this.grpUser.Controls.Add(this.lblFullName);
            this.grpUser.Location = new System.Drawing.Point(152, 227);
            this.grpUser.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grpUser.Name = "grpUser";
            this.grpUser.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.grpUser.Size = new System.Drawing.Size(874, 348);
            this.grpUser.TabIndex = 9;
            this.grpUser.TabStop = false;
            this.grpUser.Text = "User Information";
            this.grpUser.Enter += new System.EventHandler(this.grpUser_Enter);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.Location = new System.Drawing.Point(294, 274);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(105, 17);
            this.chkShowPassword.TabIndex = 11;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(294, 236);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(368, 29);
            this.txtConfirmPassword.TabIndex = 10;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(139, 240);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(139, 19);
            this.lblConfirmPassword.TabIndex = 9;
            this.lblConfirmPassword.Text = "Confirm Password :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(294, 198);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(368, 29);
            this.txtPassword.TabIndex = 8;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(197, 198);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 19);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(294, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(368, 29);
            this.txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(222, 164);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 19);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email :";
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(294, 39);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(368, 29);
            this.txtFullName.TabIndex = 4;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.Location = new System.Drawing.Point(191, 44);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(87, 19);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Full Name :";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.LightGreen;
            this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(446, 583);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 35);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Tomato;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(603, 583);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 35);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(679, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 30);
            this.comboBox1.TabIndex = 4;
            // 
            // txtCompanyID
            // 
            this.txtCompanyID.Location = new System.Drawing.Point(277, 39);
            this.txtCompanyID.Name = "txtCompanyID";
            this.txtCompanyID.Size = new System.Drawing.Size(374, 29);
            this.txtCompanyID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Address :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(294, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(368, 29);
            this.textBox2.TabIndex = 13;
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1114, 672);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.grpUser);
            this.Controls.Add(this.grpCompany);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmSignUp";
            this.Text = "SignUpForm";
            this.grpCompany.ResumeLayout(false);
            this.grpCompany.PerformLayout();
            this.grpUser.ResumeLayout(false);
            this.grpUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpCompany;
        private System.Windows.Forms.Label lblCompanyID;
        private System.Windows.Forms.GroupBox grpUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtCompanyID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
    }
}