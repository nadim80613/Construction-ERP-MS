using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construction_ERP__Management_System
{
    public class ProjectService
    {
        

        public DataTable GetAll(int companyId, bool isSuperAdmin)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                string sql;

                if (isSuperAdmin)
                {
                    sql = @"SELECT ProjectID, CompanyID, ProjectCode, [Name], Location, StartDate, EndDate, [Status] FROM dbo.Projects ORDER BY ProjectID DESC";
                }
                else
                {
                    sql = @"SELECT ProjectID, CompanyID, ProjectCode, [Name], Location, StartDate, EndDate, [Status] FROM dbo.Projects WHERE CompanyID=@CompanyID ORDER BY ProjectID DESC";
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
                    sql = @"SELECT ProjectID, CompanyID, ProjectCode, [Name], Location, StartDate, EndDate, [Status] FROM dbo.Projects WHERE (ProjectCode LIKE @K OR [Name] LIKE @K OR [Status] LIKE @K) ORDER BY ProjectID DESC";
                }
                else
                {
                    sql = @"SELECT ProjectID, CompanyID, ProjectCode, [Name], Location, StartDate, EndDate, [Status] FROM dbo.Projects WHERE CompanyID=@CompanyID AND (ProjectCode LIKE @K OR [Name] LIKE @K OR [Status] LIKE @K) ORDER BY ProjectID DESC";
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

        public bool Insert(int companyId, string code, string name, string location,
                           DateTime start, DateTime end, string status)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                string sql = @"INSERT INTO dbo.Projects (CompanyID, ProjectCode, [Name], Location, StartDate, EndDate, [Status], CreatedAt) VALUES (@CompanyID, @ProjectCode, @Name, @Location, @StartDate, @EndDate, @Status, SYSDATETIME())";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@CompanyID", companyId);
                    cmd.Parameters.AddWithValue("@ProjectCode", code);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Location", location);
                    cmd.Parameters.AddWithValue("@StartDate", start);
                    cmd.Parameters.AddWithValue("@EndDate", end);
                    cmd.Parameters.AddWithValue("@Status", status);

                    int row = cmd.ExecuteNonQuery();

                    if (row > 0)
                        return true;
                    else
                        return false;
             }
          }
        }

        public bool Update(int projectId, int companyId, string code, string name, string location,
                           DateTime start, DateTime end, string status)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                string sql = @"UPDATE dbo.Projects SET CompanyID=@CompanyID,  ProjectCode=@ProjectCode, [Name]=@Name, Location=@Location,    StartDate=@StartDate, EndDate=@EndDate,      [Status]=@Status WHERE ProjectID=@ProjectID";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);
                    cmd.Parameters.AddWithValue("@CompanyID", companyId);
                    cmd.Parameters.AddWithValue("@ProjectCode", code);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Location", location);
                    cmd.Parameters.AddWithValue("@StartDate", start);
                    cmd.Parameters.AddWithValue("@EndDate", end);
                    cmd.Parameters.AddWithValue("@Status", status);

                    int row = cmd.ExecuteNonQuery();

                    if (row > 0)
                        return true;
                    else
                        return false;
               }
            }
      }

        public bool Delete(int projectId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                string sql = @"DELETE FROM dbo.Projects WHERE ProjectID=@ProjectID";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ProjectID", projectId);

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
