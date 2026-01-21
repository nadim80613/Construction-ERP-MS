using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Construction_ERP__Management_System
{
    public partial class frmUserManagement : Form
    {
        public frmUserManagement()
        {
            InitializeComponent();
            this.Load += frmUserManagement_Load;

            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.MouseClick += dgvUsers_MouseClick;

            btnUpdateStatus.Click += btnUpdateStatus_Click;
            btnUpdateRole.Click += btnUpdateRole_Click;

            cboCompany.SelectedIndexChanged += cboCompany_SelectedIndexChanged;

            cboRole.Items.Clear();
            cboRole.Items.Add("Admin");
            cboRole.Items.Add("User");
            cboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cboRole.SelectedIndex = 0;

            cboStatus.Items.Clear();
            cboStatus.Items.Add("Active");
            cboStatus.Items.Add("Inactive");
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.SelectedIndex = 0;
        }

        private int selectedUserId = 0;

        private void LoadUsers()
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                string query = "SELECT UserID, CompanyID, Name, Email, Role, Status, CreatedAt FROM Users ORDER BY UserID DESC";

                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUsers.DataSource = dt;
                }
            }

            dgvUsers.ClearSelection();
            dgvUsers.CurrentCell = null;


        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblRole_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            if (!Session.IsSuperAdmin())
            {
                MessageBox.Show("Only Super Admin can change roles.");
                return;
            }

            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            if (cboRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a role.");
                return;
            }

            string role = cboRole.SelectedItem.ToString();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                string q = "UPDATE Users SET Role=@Role WHERE UserID=@UserID";

                using (SqlCommand cmd = new SqlCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@Role", role);
                    cmd.Parameters.AddWithValue("@UserID", selectedUserId);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadUsersByCompany(Convert.ToInt32(cboCompany.SelectedValue));


        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var main = Application.OpenForms["frmMain"] as frmMain;
            if (main != null)
            {
                main.Navigate(new UcDashboard()); 
            }
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadUsersForCurrentUserCompany()
        {
            int companyId;

            if (Session.IsSuperAdmin())
            {
                // super admin: dropdown selected company
                if (cboCompany.SelectedValue == null) return;
                companyId = Convert.ToInt32(cboCompany.SelectedValue);
            }
            else
            {
                // company admin: own company only
                companyId = Session.CompanyID;
            }

            LoadUsersByCompany(companyId);
        }

        private void LoadCompanies()
        {
            using(SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT CompanyID, Name FROM Companies ORDER BY Name";
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);


                    cboCompany.DisplayMember = "Name";
                    cboCompany.ValueMember = "CompanyID";
                    cboCompany.DataSource = dt;

                }
            }
        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {


            if (Session.IsSuperAdmin())
            {
                cboCompany.Visible = true;
                lblCompany.Visible = true;
                LoadCompanies();
            }
            else
            {
                cboCompany.Visible = false;
                lblCompany.Visible = false;
            }

            

        }





        private void dgvUsers_MouseClick(object sender, MouseEventArgs e)
        {
            if (dgvUsers.CurrentRow == null)
            {
                return;
            }

            object v = dgvUsers.CurrentRow.Cells["UserID"].Value;
            if (v == null)
            {
                return;
            }

            selectedUserId = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value);

            txtUserID.Text = selectedUserId.ToString();
            txtName.Text = dgvUsers.CurrentRow.Cells["Name"].Value.ToString();
            txtEmail.Text = dgvUsers.CurrentRow.Cells["Email"].Value.ToString();

            string role = "";
            if (dgvUsers.CurrentRow.Cells["Role"].Value != null)
            {
                role = dgvUsers.CurrentRow.Cells["Role"].Value.ToString();
            }

            if (role == "Admin")
            {
                cboRole.SelectedItem = "Admin";
            }
            else
            {
                cboRole.SelectedItem = "User";
            }



            string status = "";
            if (dgvUsers.CurrentRow.Cells["Status"].Value != null)
            {
                status = dgvUsers.CurrentRow.Cells["Status"].Value.ToString();

            }

            if (status == "Active")
            {
                cboStatus.SelectedItem = "Active";
            }
            else
            {
                cboStatus.SelectedItem = "Inactive";
            }
        }




        private void btnUpdateStatus_Click(object sender, EventArgs e)
                {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            if (cboStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            int companyId;
            if (Session.IsSuperAdmin())
                companyId = Convert.ToInt32(cboCompany.SelectedValue);
            else
                companyId = Session.CompanyID;

            string status = cboStatus.SelectedItem.ToString();

            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();

                string q = "UPDATE Users SET Status=@Status WHERE UserID=@UserID AND CompanyID=@CompanyID";

                using (SqlCommand cmd = new SqlCommand(q, con))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@UserID", selectedUserId);
                    cmd.Parameters.AddWithValue("@CompanyID", companyId);

                    int row = cmd.ExecuteNonQuery();

                    if (row > 0)
                        MessageBox.Show("Status Updated!");
                    else
                        MessageBox.Show("Update Failed (not allowed).");
                }
            }

            // refresh grid
            if (Session.IsSuperAdmin())
                LoadUsersByCompany(Convert.ToInt32(cboCompany.SelectedValue));
            else
                LoadUsersByCompany(Session.CompanyID);

        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            selectedUserId = 0;

            txtUserID.Clear();
            txtName.Clear();
            txtEmail.Clear();

            cboRole.SelectedIndex = -1;
            cboStatus.SelectedIndex = -1;

            dgvUsers.ClearSelection();
            dgvUsers.CurrentCell = null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
            dgvUsers.ClearSelection();
            dgvUsers.CurrentCell = null;
        }

        private void LoadUsersByCompany(int companyId)
        {
            using (SqlConnection con = DbConnection.GetConnection())
            {
                con.Open();
                string query = "SELECT UserID, CompanyID, Name, Email, Role, Status, CreatedAt FROM Users WHERE CompanyID = @CompanyID ORDER BY UserID DESC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@CompanyID", companyId);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvUsers.DataSource = dt;
                    }
                }

                
            }
        }

        private void cboCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCompany.SelectedValue == null)
            {
                return;
            }

            int companyId = Convert.ToInt32(cboCompany.SelectedValue);
            LoadUsersByCompany(companyId);

            dgvUsers.ClearSelection();
            dgvUsers.CurrentCell = null;

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            if (Session.IsSuperAdmin())
            {
                int companyId = Convert.ToInt32(cboCompany.SelectedValue);
                LoadUsersByCompany(companyId);
            }
            else
            {
               LoadUsersByCompany(Session.CompanyID);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
