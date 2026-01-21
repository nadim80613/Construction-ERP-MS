using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construction_ERP__Management_System
{
    public partial class UcVendorManagement : UserControl
    {
        public UcVendorManagement()
        {
            InitializeComponent();
        }
        private void ApplyPermission()
        {
            if (Session.IsSuperAdmin())
            {
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
                btnDelete.Visible = true;
            }
            else
            {
                if (Session.IsAdmin())
                {
                    btnSave.Enabled = true;
                    btnDelete.Enabled = false;
                    btnDelete.Visible = false;
                }
                else
                {
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                    btnDelete.Visible = false;
                }
            }
        }

        VendorService vs = new VendorService();

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

            dgvVendors.DataSource = vs.GetAll(companyId, isSuperAdmin);
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void UcVendorManagement_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Inactive");
            cmbStatus.SelectedIndex = 0;



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
            
        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCompanyID.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            cmbStatus.SelectedIndex = 0;
            if(!Session.IsSuperAdmin())
            {
                txtCompanyID.Text = Session.CompanyID.ToString();
            }
        }

        private int vendorId = 0;
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

            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string status = cmbStatus.SelectedItem.ToString();

            if (name == "")
            {
                MessageBox.Show("You have to fill Vendor Name");
                return;
            }

            bool isSuper = Session.IsSuperAdmin();
            int targetCompanyId = companyId;

            bool ok = false;

            if (vendorId == 0)
            {
                ok = vs.Insert(Session.CompanyID, isSuper, targetCompanyId, name, phone, email, status);

                if (ok) MessageBox.Show("Vendor Created!");
                else MessageBox.Show("Create failed!");
            }
            else
            {
                ok = vs.Update(vendorId, Session.CompanyID, isSuper, targetCompanyId, name, phone, email, status);

                if (ok) MessageBox.Show("Vendor Updated!");
                else MessageBox.Show("Update failed!");
            }

            LoadGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!Session.IsSuperAdmin())
            {
                MessageBox.Show("Access Denied!");
                return;
            }

            if (vendorId == 0)
            {
                MessageBox.Show("Please select a vendor to delete");
                return;
            }

            DialogResult confirm = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            bool ok = vs.Delete(vendorId);

            if (ok) MessageBox.Show("Deleted!");
            else MessageBox.Show("Delete failed!");

            btnClear_Click(null, null);
            LoadGrid();
        }

        private void dgvVendors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow r = dgvVendors.Rows[e.RowIndex];

            if (r.Cells[0].Value != null)
                vendorId = Convert.ToInt32(r.Cells[0].Value);
            else
                vendorId = 0;

            if (r.Cells[1].Value != null)
                txtCompanyID.Text = r.Cells[1].Value.ToString();
            else
                txtCompanyID.Text = "";

            if (r.Cells[2].Value != null)
                txtName.Text = r.Cells[2].Value.ToString();
            else
                txtName.Text = "";

            if (r.Cells[4].Value != null)
                txtPhone.Text = r.Cells[4].Value.ToString();
            else
                txtPhone.Text = "";

            if (r.Cells[5].Value != null)
                txtEmail.Text = r.Cells[5].Value.ToString();
            else
                txtEmail.Text = "";

            if (r.Cells[6].Value != null)
                cmbStatus.SelectedItem = r.Cells[6].Value.ToString();
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
                dgvVendors.DataSource = vs.GetAll(companyId, isSuper);
            }
            else
            {
                dgvVendors.DataSource = vs.Search(companyId, isSuper, k);
            }
        }
    }
}
