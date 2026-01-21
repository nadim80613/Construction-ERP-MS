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
        private readonly UcProductManagement UcProductManagement = new UcProductManagement();

        public void Navigate(UserControl page)
        {
            panelMain.Controls.Clear();
            page.Dock = DockStyle.Fill;
            panelMain.Controls.Add(page);
        }

        private void UpdateHeader()
        {
            string user = "";
            string roleText = "";
            string company = "";

            if (Session.UserName != null)
                user = Session.UserName;
            else
                user = "";

            company = Session.CompanyID.ToString();

            if (Session.IsSuperAdmin())
            {
                roleText = "SuperAdmin";
            }
            else
            {
                if (Session.Role != null)
                {
                    if (Session.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                        roleText = "Admin";
                    else
                    {
                        if (Session.Role.Equals("User", StringComparison.OrdinalIgnoreCase))
                            roleText = "User";
                        else
                        {
                            if (Session.Role.Equals("Vendor", StringComparison.OrdinalIgnoreCase))
                                roleText = "Vendor";
                            else
                                roleText = Session.Role;
                        }
                    }
                }
                else
                {
                    roleText = "";
                }
            }

            lblUserInfo.Text = "User: " + user + " | Role: " + roleText + " | Company: " + company;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {



            btnCompanySetup.Visible = Session.IsSuperAdmin();
            btnUserManagement.Visible = Session.IsAdmin() || Session.IsSuperAdmin();

            UpdateHeader();


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

            frmCompanySetup fcs = new frmCompanySetup();
            ShowFormInPanel(fcs);
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            if (!Session.IsAdmin() && !Session.IsSuperAdmin())
            {
                MessageBox.Show("Access Denied! only Admin/Super Admin can acess");
                return;
            }

            frmUserManagement fum = new frmUserManagement();
            ShowFormInPanel(fum);
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

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Navigate(new UcProductManagement());
        }

        public void ShowFormInPanel(Form f)
        {
            panelMain.Controls.Clear();

            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;

            panelMain.Controls.Add(f);
            f.Show();
            f.BringToFront();
        }
    }
}
