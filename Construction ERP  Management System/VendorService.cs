using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_ERP__Management_System
{
    public class VendorService
    {
        public DataTable GetAll(int companyId, bool isSuperAdmin)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                string sql;

                if (isSuperAdmin)
                {
                    sql = @"SELECT VendorID, CompanyID, [Name], [Type], Phone, Email, [Status], CreatedAt
                            FROM dbo.Vendors
                            ORDER BY VendorID DESC";
                }
                else
                {
                    sql = @"SELECT VendorID, CompanyID, [Name], [Type], Phone, Email, [Status], CreatedAt
                            FROM dbo.Vendors
                            WHERE CompanyID=@CompanyID
                            ORDER BY VendorID DESC";
                }

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (isSuperAdmin == false)
                    {
                        cmd.Parameters.AddWithValue("@CompanyID", companyId);
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public DataTable Search(int companyId, bool isSuperAdmin, string keyword)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                string sql;

                if (isSuperAdmin)
                {
                    sql = @"SELECT VendorID, CompanyID, [Name], [Type], Phone, Email, [Status], CreatedAt FROM dbo.Vendors WHERE ([Name] LIKE @K OR Email LIKE @K OR Phone LIKE @K OR [Status] LIKE @K OR [Type] LIKE @K) ORDER BY VendorID DESC";
                }
                else
                {
                    sql = @"SELECT VendorID, CompanyID, [Name], [Type], Phone, Email, [Status], CreatedAt FROM dbo.Vendors WHERE CompanyID=@CompanyID AND ([Name] LIKE @K OR Email LIKE @K OR Phone LIKE @K OR [Status] LIKE @K OR [Type] LIKE @K) ORDER BY VendorID DESC";
                }

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@K", "%" + keyword + "%");

                    if (isSuperAdmin == false)
                    {
                        cmd.Parameters.AddWithValue("@CompanyID", companyId);
                    }

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public bool Insert(int companyId, bool isSuperAdmin, int targetCompanyId,
                           string name, string phone, string email, string status)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                int cid = companyId;

                if (isSuperAdmin)
                {
                    cid = targetCompanyId;
                }

                string vendorType = "Supplier";

                string sql = @"INSERT INTO dbo.Vendors (CompanyID, [Name], [Type], Phone, Email, [Status], CreatedAt) VALUES (@CompanyID, @Name, @Type, @Phone, @Email, @Status, SYSDATETIME())";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@CompanyID", cid);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Type", vendorType);

                    if (phone == "")
                        cmd.Parameters.AddWithValue("@Phone", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@Phone", phone);

                    if (email == "")
                        cmd.Parameters.AddWithValue("@Email", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@Email", email);

                    cmd.Parameters.AddWithValue("@Status", status);

                    int row = cmd.ExecuteNonQuery();

                    if (row > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public bool Update(int vendorId, int companyId, bool isSuperAdmin, int targetCompanyId,
                           string name, string phone, string email, string status)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                int cid = companyId;

                if (isSuperAdmin)
                {
                    cid = targetCompanyId;
                }

                string vendorType = "Supplier";

                string sql = @"UPDATE dbo.Vendors SET CompanyID=@CompanyID, [Name]=@Name, [Type]=@Type, Phone=@Phone, Email=@Email, [Status]=@Status WHERE VendorID=@VendorID";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@VendorID", vendorId);
                    cmd.Parameters.AddWithValue("@CompanyID", cid);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Type", vendorType);

                    if (phone == "")
                        cmd.Parameters.AddWithValue("@Phone", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@Phone", phone);

                    if (email == "")
                        cmd.Parameters.AddWithValue("@Email", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@Email", email);

                    cmd.Parameters.AddWithValue("@Status", status);

                    int row = cmd.ExecuteNonQuery();

                    if (row > 0)
                        return true;
                    else
                        return false;
                }
            }
        }

        public bool Delete(int vendorId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                string sql = @"DELETE FROM dbo.Vendors WHERE VendorID=@VendorID";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@VendorID", vendorId);

                    int row = cmd.ExecuteNonQuery();

                    if (row > 0)
                        return true;
                    else
                        return false;
                }
            }
        }
    }
}
