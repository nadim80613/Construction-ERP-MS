using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace Construction_ERP__Management_System
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

 


        private void grpUser_Enter(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.Show();
            this.Hide();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
           txtConfirmPassword.UseSystemPasswordChar = true;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chkShowPassword.Checked;

            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
            txtConfirmPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }
        private bool CompanyExists(SqlConnection con, int companyID)
        {
            string query = "SELECT COUNT(1) FROM Companies WHERE CompanyID = @CompanyID";
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@CompanyID", companyID);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes= sha.ComputeHash(Encoding.UTF8.GetBytes(password));

                return Convert.ToBase64String(bytes);
            }
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCompanyID.Text.Trim(), out int companyID))
            {
                MessageBox.Show("Please enter a valid Company ID.");
                return;
            }
            string fullName = txtFullName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(fullName) ||
               string.IsNullOrWhiteSpace(email) ||
               string.IsNullOrWhiteSpace(password) ||
               string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    con.Open();

                    if (!CompanyExists(con, companyID))
                    {
                        MessageBox.Show("Company ID does not exist.Please contract with Admin");
                        return;
                    }

                    string hash = HashPassword(password);

                    string q = @"INSERT INTO Users (CompanyID, Name, Email, PasswordHash,Role,Status,CreatedAt) 
                                 VALUES (@CompanyID, @Name, @Email, @PasswordHash,@Role,@Status,getdate())";

                    using (SqlCommand cmd = new SqlCommand(q, con))
                    {
                        cmd.Parameters.AddWithValue("@CompanyID", companyID);
                        cmd.Parameters.AddWithValue("@Name", fullName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@PasswordHash", hash);
                        cmd.Parameters.AddWithValue("@Role", "User");
                        cmd.Parameters.AddWithValue("@Status", "Active");
                        cmd.ExecuteNonQuery();



                    }
                }

                MessageBox.Show("Registration successful! You can now log in.");
                //this.Close();
            }
            catch(Exception ex)
            {
                //Dupliate email error handling
                //2627 = is the SQL Server error code for unique constraint violation
                //2601 = Cannot insert duplicate key row in object with unique index
                if (ex is SqlException sqlEx && (sqlEx.Number == 2627 || sqlEx.Number == 2601))
                {
                    MessageBox.Show("The email address is already registered. Please use a different email.");
                }
                else
                {
                    MessageBox.Show("An error occurred during registration: " + ex.Message);
                }

            }
        }
    }
}
