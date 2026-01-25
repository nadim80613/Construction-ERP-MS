using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construction_ERP__Management_System
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp suf = new frmSignUp();
            suf.Show();
            this.Hide();

        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT DB_NAME()", con))
                {
                    var dbName = cmd.ExecuteScalar()?.ToString();
                    MessageBox.Show("Connected DB: "+ dbName);
                }
            }


            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            string passwordHash = PasswordHelper.HashPassword(password);

            using (SqlConnection con = DbConnection.GetConnection())
            {
                string sql = @"SELECT u.UserID, u.CompanyID, u.Name, u.Role, u.Status, u.PasswordHash, c.Name AS CompanyName FROM dbo.Users u INNER JOIN dbo.Companies c ON c.CompanyID = u.CompanyID WHERE u.Email=@Email";

                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Email", email);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (!reader.Read())
                {
                    MessageBox.Show("Invalid email or password.");
                    return;
                }

                string status = reader["Status"].ToString();

                if (status != "Active")
                {
                    MessageBox.Show("Your account is not active.");
                    return;
                }

                string dbpass = reader["PasswordHash"].ToString();
                if (dbpass != passwordHash)
                {
                    MessageBox.Show("Invalid email or password.");
                    return;
                }

                string role = reader["Role"].ToString();
                string name = reader["Name"].ToString();
                int companyID = Convert.ToInt32(reader["CompanyID"]);
                string companyName = reader["CompanyName"].ToString();

                MessageBox.Show("Welcome!" + name);

                Session.UserID = Convert.ToInt32(reader["UserID"]);
                Session.CompanyID = companyID;
                Session.UserName = name;
                Session.Email = email;
                Session.Role = role;
                Session.CompanyName = companyName;

                frmMain fm = new frmMain();
                fm.Show();
                this.Hide();
            }



        }
      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

