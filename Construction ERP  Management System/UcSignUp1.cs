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
    public partial class UcSignUp1 : UserControl
    {
        public UcSignUp1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            string companyName = txtCompanyName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string taxId = txtTaxID.Text.Trim();
            string adminEmail = txtEmail.Text.Trim();
            string pass = txtPassword.Text;
            string confirm = txtConfirmPassword.Text;

            if (companyName == "" || address == "" || taxId == "" || adminEmail == "" || pass == "" || confirm == "")
            {
                MessageBox.Show("Please fill all the feild");
                return;
            }
            else if (pass != confirm)
            {
                MessageBox.Show("Password did not match");
                return;
            }
            else
            {
                SignUpService s = new SignUpService();
                int companyId = s.RegisterCompanyWithAdmin(companyName, address, taxId, adminEmail, pass);

                if (companyId == -1)
                {
                    MessageBox.Show(" Email already used , please try different Email");
                    return;
                }

                MessageBox.Show("Company + Admin Created Successfully!\nYour CompanyID: " + companyId);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }

       
 }

