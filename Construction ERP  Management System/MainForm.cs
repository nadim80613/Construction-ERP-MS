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
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome, " + Session.UserName + "!";
            lblUserInfo.Text = "User : " + Session.UserName + " | Role : " + Session.Role + " | Company ID : " + Session.CompanyID.ToString();

            btnCompanySetup.Visible = Session.IsSuperAdmin();
            btnUserManagement.Visible = Session.IsAdmin();



        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnCompanySetup_Click(object sender, EventArgs e)
        {
            if (!Session.IsSuperAdmin())
            {
                MessageBox.Show("Access Denied. only Super Admin can acess");
                return;
            }

            frmCompanySetup fcs = new frmCompanySetup();
            fcs.Show();
            this.Hide();
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
    }
}
