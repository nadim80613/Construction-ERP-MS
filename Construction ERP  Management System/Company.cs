using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Construction_ERP__Management_System
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string TaxID { get; set; }

        public DataTable ShowAll()
        {
            DataTable dt = new DataTable();

            try
            {
                using (SqlConnection con = DbConnection.GetConnection())
                {
                    con.Open();

                    string q = @"SELECT CompanyID, Name, Address, TaxID, CreatedAt
                                 FROM Companies
                                 ORDER BY CompanyID DESC";

                    using (SqlDataAdapter da = new SqlDataAdapter(q, con))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ShowAll Error:\n" + ex.Message);
            }

            return dt; 
        }

        public bool Insert(Company c)
        {
            bool isSuccess = false;
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                try
                {
                    string q = "INSERT INTO Companies (Name, Address, TaxID, CreatedAt) VALUES (@Name, @Address, @TaxID,getdate())";

                    SqlCommand cmd = new SqlCommand(q, con);
                    cmd.Parameters.AddWithValue("@Name", c.CompanyName);
                    cmd.Parameters.AddWithValue("@Address", c.Address);
                    cmd.Parameters.AddWithValue("@TaxID", c.TaxID);

                    int row = cmd.ExecuteNonQuery();

                    MessageBox.Show("Company Added " + row);
                    return row > 0;





                }
                catch (Exception ex)

                {
                    MessageBox.Show("Inserted Error:/n" + ex.Message);
                    return false;

                }
                finally
                {
                    con.Close();
                }

                return isSuccess;

            }

        }

        public bool update (Company c)
        {
            bool isSuccess = false;
            try
            {


                using (SqlConnection con = DbConnection.GetConnection())
                {
                    con.Open();

                    string q = @"UPDATE Companies SET Name=@Name, Address=@Address,TaxID=@TaxID WHERE CompanyID=@CompanyID";

                    using (SqlCommand cmd = new SqlCommand(q, con))
                    {
                        cmd.Parameters.AddWithValue("@CompanyID", c.CompanyID);
                        cmd.Parameters.AddWithValue("@Name", c.CompanyName);
                        cmd.Parameters.AddWithValue("@Address", c.Address);
                        cmd.Parameters.AddWithValue("@TaxID", c.TaxID);

                        int row = cmd.ExecuteNonQuery();
                        MessageBox.Show("Update rows" + row);
                        return row > 0;
                    }
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show("Update Error:/n" + ex.Message);
                return false;

            }


            return isSuccess;
        }



    }
}
