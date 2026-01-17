using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Construction_ERP__Management_System
{
    public static class DbConnection
    {
        private static readonly string dbFilePath =
            @"C:/Users/nadim/Documents/ConstructionERP_DB.mdf";

        private static readonly string connectionString =
            $@"Data Source=(LocalDB)\MSSQLLocalDB;
               AttachDbFilename={dbFilePath};
               Integrated Security=True;
               Connect Timeout=30";

        public static SqlConnection GetConnection()
        {
            if (!File.Exists(dbFilePath))
            {
                CreateDatabase(dbFilePath);
            }

            return new SqlConnection(connectionString);
        }

        private static void CreateDatabase(string dbFilePath)
        {
            string masterConn =
                @"Data Source=(LocalDB)\MSSQLLocalDB;Integrated Security=True;";

            string dbName = "ConstructionERP_DB";

            string sql = $@"
            CREATE DATABASE [{dbName}]
            ON (NAME = '{dbName}',
                FILENAME = '{dbFilePath}')";

            using (SqlConnection conn = new SqlConnection(masterConn))
            {
                conn.Open();

                try
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Database creation failed: " + ex.Message);
                    
                }
            }
        }
    }
   }