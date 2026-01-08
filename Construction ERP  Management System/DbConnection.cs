using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;    

namespace Construction_ERP__Management_System
{
    public static class DbConnection
    {
        
        
         public static  string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nadim\Documents\ConstructionERP_DB.mdf;Integrated Security=True;Connect Timeout=30";
         
        public static SqlConnection GetConnection()
        {

            return new SqlConnection(connectionString);
        }


    }
}
