using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construction_ERP__Management_System
{
    public partial class UcSignUp3 : UserControl
    {
        public UcSignUp3()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void gB2_Enter(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string companyIdText = txtCompanyID.Text.Trim();
            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string pass = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;
            string phone = txtPhone.Text.Trim();

            if (companyIdText == "" || name == "" || email == "" || pass == "" || confirm == "")
            {
                MessageBox.Show("Please fill all the feild");
                return;
            }
            else
            {
                int companyId = 0;

                if (!int.TryParse(companyIdText, out companyId))
                {
                    MessageBox.Show("Invalid CompanyID");
                    return;
                }
                else
                {
                    if (pass != confirm)
                    {
                        MessageBox.Show("Password did not match");
                        return;
                    }
                    else
                    {
                        SignUpService s = new SignUpService();
                        bool ok = s.RegisterVendor(companyId, name, email, pass, phone);

                        if (ok == false)
                        {
                            MessageBox.Show(" Email already used , please try different Email");
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Vendor Created Successfully!");
                        }
                    }
                }
            }
        }
    }
}
