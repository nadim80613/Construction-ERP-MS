using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Construction_ERP__Management_System
{
    public partial class frmCompanySetup : Form
    {
        public frmCompanySetup()
        {
            InitializeComponent();
        }



        
        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblFullName_Click(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCompanySetup_Load(object sender, EventArgs e)
        {

        }

        private void btnAdminLogout_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        Company c = new Company();
        private int selectedCompanyID = 0;

        private void btnSave_Click(object sender, EventArgs e)
        {
            c.CompanyName = txtCompanyName.Text;
            c.Address = txtCompanyAddress.Text;
            c.TaxID = txtTaxID.Text;

            bool ok = c.Insert(c);
            MessageBox.Show(ok ? "Company saved successfully." : "Failed to save company.");

            dgvCompanies.DataSource = c.ShowAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("selectedCompanyID"+ selectedCompanyID);

            if (selectedCompanyID == 0)
            {
                MessageBox.Show("Please select a company to update");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCompanyName.Text) || string.IsNullOrWhiteSpace(txtTaxID.Text))
            {
                MessageBox.Show("Name and TaxID required.");
                return;
            }

            Company obj = new Company();
            obj.CompanyID = selectedCompanyID;
            obj.CompanyName = txtCompanyName.Text.Trim();
            obj.Address = txtCompanyAddress.Text.Trim();
            obj.TaxID = txtTaxID.Text.Trim();

            bool ok = c.Update(obj);

            MessageBox.Show(ok ? "Successfully Updated!" : "Update Failed!");

            dgvCompanies.DataSource = c.ShowAll();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCompanyName.Clear();
            txtCompanyAddress.Clear();
            txtTaxID.Clear();
        }

        private void dgvCompanies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCompanies_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedCompanyID = Convert.ToInt32(dgvCompanies.Rows[e.RowIndex].Cells["CompanyID"].Value);
            int row_index = e.RowIndex;
            txtCompanyName.Text = dgvCompanies.Rows[row_index].Cells[1].Value.ToString();
            txtCompanyAddress.Text = dgvCompanies.Rows[row_index].Cells[2].Value.ToString();
            txtTaxID.Text = dgvCompanies.Rows[row_index].Cells[3].Value.ToString();
            this.Text = "Selected Company ID = " + selectedCompanyID;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            DataTable dt = c.ShowAll();
            dgvCompanies.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCompanyID == 0)
            {
                MessageBox.Show("Please selecte a company to delete");
                return;
            }

            var dr = MessageBox.Show("Delete this company?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr != DialogResult.Yes)
            {
                return;
            }

            else
            {
                Company obj = new Company();
                obj.CompanyID = selectedCompanyID;

                bool ok = obj.Delete(obj);

                MessageBox.Show(ok ? "Deleted!" : "delete Failed!");

                dgvCompanies.DataSource = obj.ShowAll();
            }


        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Company c = new Company();
            dgvCompanies.DataSource = c.ShowAll();

            dgvCompanies.ClearSelection();
            dgvCompanies.CurrentCell = null;

            txtCompanyName.Clear();
            txtCompanyAddress.Clear();
            txtTaxID.Clear();

        }
    }
}
