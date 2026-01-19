using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Construction_ERP__Management_System
{
    public static class DbConnection
    {
        // Put DB inside the current user's Documents (or use LocalApplicationData if you prefer)
        private static readonly string dbFolder =
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                         "ConstructionERP");

        private static readonly string dbName = "ConstructionERP_DB";
        private static readonly string dbFilePath = Path.Combine(dbFolder, $"{dbName}.mdf");
        private static readonly string logFilePath = Path.Combine(dbFolder, $"{dbName}_log.ldf");

        private static readonly string connectionString =
            $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbFilePath};Integrated Security=True;Connect Timeout=30;";

        public static SqlConnection GetConnection()
        {
            // Make sure folder exists
            Directory.CreateDirectory(dbFolder);

            // Create DB if missing
            if (!File.Exists(dbFilePath))
            {
                CreateDatabase(dbFilePath, logFilePath);
            }

            return new SqlConnection(connectionString);
        }

        private static void CreateDatabase(string mdfPath, string ldfPath)
        {
            const string masterConn = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;";

            // Important: use N'' for unicode paths; specify both MDF + LDF in a writable folder
            string sql = $@"
CREATE DATABASE [{dbName}]
ON PRIMARY
(
    NAME = N'{dbName}',
    FILENAME = N'{mdfPath}'
)
LOG ON
(
    NAME = N'{dbName}_log',
    FILENAME = N'{ldfPath}'
);";

            try
            {
                using (SqlConnection conn = new SqlConnection(masterConn))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
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
