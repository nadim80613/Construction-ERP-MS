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
    public partial class frmMain : Form
    {
        public frmMain()
        {

            InitializeComponent();
            Navigate(new UcDashboard());
        }

        private readonly UcCompanySetup UcCompanySetup = new UcCompanySetup();
        private readonly UcVendorManagement ucVendorManagement = new UcVendorManagement();
        private readonly UcProjectManagement ucProjectManagement = new UcProjectManagement();   

        private void Navigate(UserControl page)
        {
            panelMain.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelMain.Controls.Add(page);
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            
           

            btnCompanySetup.Visible = Session.IsSuperAdmin();
            btnUserManagement.Visible = Session.IsAdmin();



        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Navigate(new UcDashboard());

        }

        private void btnCompanySetup_Click(object sender, EventArgs e)
        {
            if (!Session.IsSuperAdmin())
            {
                MessageBox.Show("Access Denied. only Super Admin can acess");
                return;
            }

            Navigate(new UcCompanySetup());
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            if (!Session.IsAdmin())
            {
                MessageBox.Show("Access Denied! only admin can acess");
                return;
            }

            frmUserManagement fum = new frmUserManagement();
            fum.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.Show();
            this.Hide();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            Navigate(new UcProjectManagement());
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            Navigate(new UcVendorManagement());
        }
    }
}
