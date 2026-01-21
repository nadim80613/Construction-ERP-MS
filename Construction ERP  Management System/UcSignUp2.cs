using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Construction_ERP__Management_System
{
    public partial class UcSignUp2 : UserControl
    {
        public UcSignUp2()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string CompanyID = txtCompanyID.Text.Trim();
            string Name = txtUserName.Text.Trim();
            string Email = txtEmail.Text.Trim();
            string Password = txtPassword.Text;
            string ConfirmPassword = txtConfirmPassword.Text;

            if (Name == "" || Email == "" || Password == "" || ConfirmPassword == "")
            {
                MessageBox.Show("Please fill all the feild");
                return;
            }
            else if (Password != ConfirmPassword)
            {
                MessageBox.Show("Password did not match");
                return;
            }
            else
            {
                int companyId = 0;

                try
                {
                    companyId = Convert.ToInt32(CompanyID);
                }
                catch
                {
                    MessageBox.Show("CompanyID  Mandatory ");
                    return;
                }

                SignUpService s = new SignUpService();
                bool ok = s.RegisterUser(companyId, Name, Email, Password);

                if (ok == true)
                {
                    MessageBox.Show("User Created Successfully!");
                }
                else
                {
                    MessageBox.Show(" Email already used , try different Email .");
                }
            }
        }
    }
}
