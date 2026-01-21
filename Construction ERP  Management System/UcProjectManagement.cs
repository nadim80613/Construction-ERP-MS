using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construction_ERP__Management_System
{
    public partial class UcProjectManagement : UserControl
    {
        public UcProjectManagement()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ApplyPermission()
        {
            if (Session.IsAdmin() || Session.IsSuperAdmin())
            {
                btnSave.Enabled = true;

                btnDelete.Enabled = true;
            }
            else
            {
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
            }


        }

        ProjectService ps = new ProjectService();
        private void LoadGrid()
        {
            int companyId = Session.CompanyID;
            bool isSuperAdmin = Session.IsSuperAdmin();

            if (isSuperAdmin)
            {
                int cid;

                if (int.TryParse(txtCompanyID.Text, out cid))
                {
                    companyId = cid;
                }

            }

            dgvProjects.DataSource = ps.GetAll(companyId, isSuperAdmin);
        }

        private void UcProjectManagement_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Draft");
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Closed");
            cmbStatus.SelectedIndex = 0;

            txtProjectID.ReadOnly = true;

            if (Session.IsSuperAdmin())
            {
                txtCompanyID.ReadOnly = false;
            }
            else
            {
                txtCompanyID.ReadOnly = true;
                txtCompanyID.Text = Session.CompanyID.ToString();
            }
            ApplyPermission();
            LoadGrid();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProjectID.Text = "";
            txtCode.Text = "";
            txtName.Text = "";
            txtLocation.Text = "";

            dtStart.Value = DateTime.Today;
            dtEnd.Value = DateTime.Today;

            cmbStatus.SelectedIndex = 0;

            if (!Session.IsSuperAdmin())
            {
                txtCompanyID.Text = Session.CompanyID.ToString();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!Session.IsAdmin() && !Session.IsSuperAdmin())
            {
                MessageBox.Show("Access Denied!");
                return;
            }

            int companyId;
            if (!int.TryParse(txtCompanyID.Text.Trim(), out companyId))
            {
                MessageBox.Show("Company ID invalid");
                return;
            }

            string code = txtCode.Text.Trim();
            string name = txtName.Text.Trim();
            string location = txtLocation.Text.Trim();
            string status = cmbStatus.SelectedItem.ToString();

            if (code == "" || name == "")
            {
                MessageBox.Show(" you have to fill Project Code and   Project Name ");
                return;
            }

            bool ok = false;

            if (txtProjectID.Text.Trim() == "")
            {
                ok = ps.Insert(companyId, code, name, location, dtStart.Value, dtEnd.Value, status);

                if (ok) MessageBox.Show("Project Created!");
                else MessageBox.Show("Create failed!");
            }
            else
            {
                int projectId = Convert.ToInt32(txtProjectID.Text.Trim());

                ok = ps.Update(projectId, companyId, code, name, location, dtStart.Value, dtEnd.Value, status);

                if (ok) MessageBox.Show("Project Updated!");
                else MessageBox.Show("Update failed!");
            }

            LoadGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!Session.IsAdmin() && !Session.IsSuperAdmin())
            {
                MessageBox.Show("Access Denied!");
                return;
            }

            if (txtProjectID.Text.Trim() == "")
            {
                MessageBox.Show("Please select a poject to delete");
                return;
            }

            int projectId = Convert.ToInt32(txtProjectID.Text.Trim());

            DialogResult confirm = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            bool ok = ps.Delete(projectId);

            if (ok) MessageBox.Show("Deleted!");
            else MessageBox.Show("Delete failed!");

            btnClear_Click(null, null);
            LoadGrid();
        }

        private void dgvProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow r = dgvProjects.Rows[e.RowIndex];

            
            if (r.Cells[0].Value != null)
                txtProjectID.Text = r.Cells[0].Value.ToString();
            else
                txtProjectID.Text = "";

           
            if (r.Cells[1].Value != null)
                txtCompanyID.Text = r.Cells[1].Value.ToString();
            else
                txtCompanyID.Text = "";

            
            if (r.Cells[2].Value != null)
                txtCode.Text = r.Cells[2].Value.ToString();
            else
                txtCode.Text = "";

            
            if (r.Cells[3].Value != null)
                txtName.Text = r.Cells[3].Value.ToString();
            else
                txtName.Text = "";

            
            if (r.Cells[4].Value != null)
                txtLocation.Text = r.Cells[4].Value.ToString();
            else
                txtLocation.Text = "";

            
            try
            {
                if (r.Cells[5].Value != null)
                    dtStart.Value = Convert.ToDateTime(r.Cells[5].Value);
                else
                    dtStart.Value = DateTime.Today;
            }
            catch
            {
                dtStart.Value = DateTime.Today;
            }

            
            try
            {
                if (r.Cells[6].Value != null)
                    dtEnd.Value = Convert.ToDateTime(r.Cells[6].Value);
                else
                    dtEnd.Value = DateTime.Today;
            }
            catch
            {
                dtEnd.Value = DateTime.Today;
            }

            
            if (r.Cells[7].Value != null)
                cmbStatus.SelectedItem = r.Cells[7].Value.ToString();
            else
                cmbStatus.SelectedIndex = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string k = txtSearch.Text.Trim();

            int companyId = Session.CompanyID;
            bool isSuper = Session.IsSuperAdmin();

            if (isSuper)
            {
                int cid;
                if (int.TryParse(txtCompanyID.Text.Trim(), out cid))
                {
                    companyId = cid;
                }
            }

            if (k == "")
            {
                dgvProjects.DataSource = ps.GetAll(companyId, isSuper);
            }
            else
            {
                dgvProjects.DataSource = ps.Search(companyId, isSuper, k);
            }
        }
    }
}
