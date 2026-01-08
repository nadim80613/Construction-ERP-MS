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
        int selectedCompanyID = 0;

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

            bool ok = c.update(obj);

            MessageBox.Show(ok ? "Successfully Updated!" : "Update Failed!");

            dgvCompanies.DataSource = c.ShowAll();
            selectedCompanyID = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvCompanies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedCompanyID = Convert.ToInt32(dgvCompanies.Rows[e.RowIndex].Cells["CompanyID"].Value);

            txtCompanyName.Text = dgvCompanies.Rows[e.RowIndex].Cells["Name"].Value?.ToString();
            txtCompanyAddress.Text = dgvCompanies.Rows[e.RowIndex].Cells["Address"].Value?.ToString();
            txtTaxID.Text = dgvCompanies.Rows[e.RowIndex].Cells["TaxID"].Value?.ToString();
        }
    }
}
