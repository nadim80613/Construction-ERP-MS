using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construction_ERP__Management_System
{
    public class SignUpService
    {
        public bool IsEmailExists(string email)
        {

            try
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM dbo.Users WHERE Email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        if (count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Inserted Error:/n" + ex.Message);
                return false;
            }

        }

        public bool RegisterCompany(string CompanyName, string Address, string TaxID, string Email, string Password)
        {
            if (IsEmailExists(Email) == true)
            {
                return false;
            }



            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();
                try
                {

                    string q1 = @"INSERT INTO dbo.Companies ([Name],[Address],TaxID) VALUES (@Name,@Address,@TaxID); SELECT CAST(SCOPE_IDENTITY() AS int)";

                    int CompanyID = 0;
                    using (SqlCommand cmd1 = new SqlCommand(q1, con, tx))
                    {
                        cmd1.Parameters.AddWithValue("@Name", CompanyName);
                        cmd1.Parameters.AddWithValue("@Address", Address);
                        cmd1.Parameters.AddWithValue("@TaxID", TaxID);
                        CompanyID = (int)cmd1.ExecuteScalar();
                    }

                    string passHash = PasswordHelper.HashPassword(Password);

                    string q2 = @"INSERT INTO dbo.Users (CompanyID,[Name],Email,PasswordHash,[Role],[Status]) VALUES (@CompanyID,@Name,@Email,@PasswordHash,@Role,@Status);";

                    using (SqlCommand cmd2 = new SqlCommand(q2, con, tx))
                    {
                        cmd2.Parameters.AddWithValue("@CompanyID", CompanyID);
                        cmd2.Parameters.AddWithValue("@Name", "Admin");
                        cmd2.Parameters.AddWithValue("@Email", Email);
                        cmd2.Parameters.AddWithValue("@PasswordHash", passHash);
                        cmd2.Parameters.AddWithValue("@Role", "Admin");
                        cmd2.Parameters.AddWithValue("@Status", "Active");
                        cmd2.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return true;

                }


                catch
                {
                    tx.Rollback();
                    throw;
                }

            }

        }


        public bool RegisterUser(int CompanyID, string Name, string Email, string Password)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();


                string q = "SELECT COUNT(*) FROM dbo.Users WHERE Email=@Email";
                using (SqlCommand cmdCheck = new SqlCommand(q, con))
                {
                    cmdCheck.Parameters.AddWithValue("@Email", Email);
                    int count = (int)cmdCheck.ExecuteScalar();

                    if (count > 0) return false;
                }

                string passHash = PasswordHelper.HashPassword(Password);

                string q2 = @"INSERT INTO dbo.Users (CompanyID,[Name],Email,PasswordHash,[Role],[Status]) VALUES (@CompanyID,@Name,@Email,@PasswordHash,@Role,@Status);";

                using (SqlCommand cmd = new SqlCommand(q2, con))
                {
                    cmd.Parameters.AddWithValue("@CompanyID", CompanyID);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@PasswordHash", passHash);
                    cmd.Parameters.AddWithValue("@Role", "User");
                    cmd.Parameters.AddWithValue("@Status", "Active");
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
        }

        public bool RegisterVendor(int CompanyID, string Name, string Email, string Password, string Phone)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                SqlTransaction tx = con.BeginTransaction();

                try
                {
                    
                    string q = "SELECT COUNT(*) FROM dbo.Users WHERE Email=@Email";
                    using (SqlCommand cmd = new SqlCommand(q, con, tx))
                    {
                        cmd.Parameters.AddWithValue("@Email", Email);
                        int count = (int)cmd.ExecuteScalar();
                        if (count > 0)
                        {
                            tx.Rollback();
                            return false;
                        }
                    }

                    string vendorType = "Supplier"; 
                    string passHash = PasswordHelper.HashPassword(Password);

                    
                    string q1 = @"INSERT INTO dbo.Vendors (CompanyID, [Name], [Type], Phone, Email, [Status]) VALUES (@CompanyID, @Name, @Type, @Phone, @Email, @Status);";

                    using (SqlCommand cmd1 = new SqlCommand(q1, con, tx))
                    {
                        cmd1.Parameters.AddWithValue("@CompanyID", CompanyID);
                        cmd1.Parameters.AddWithValue("@Name", Name);
                        cmd1.Parameters.AddWithValue("@Type", vendorType);
                        cmd1.Parameters.AddWithValue("@Phone", Phone);
                        cmd1.Parameters.AddWithValue("@Email", Email);
                        cmd1.Parameters.AddWithValue("@Status", "Active");
                        cmd1.ExecuteNonQuery();
                    }

                    
                    string q2 = @"INSERT INTO dbo.Users (CompanyID, [Name], Email, PasswordHash, [Role], [Status]) VALUES (@CompanyID, @Name, @Email, @PasswordHash, @Role, @Status);";

                    using (SqlCommand cmd2 = new SqlCommand(q2, con, tx))
                    {
                        cmd2.Parameters.AddWithValue("@CompanyID", CompanyID);
                        cmd2.Parameters.AddWithValue("@Name", Name);
                        cmd2.Parameters.AddWithValue("@Email", Email);
                        cmd2.Parameters.AddWithValue("@PasswordHash", passHash);
                        cmd2.Parameters.AddWithValue("@Role", "Vendor");
                        cmd2.Parameters.AddWithValue("@Status", "Active");
                        cmd2.ExecuteNonQuery();
                    }

                    tx.Commit();
                    return true;
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }


    }
}

