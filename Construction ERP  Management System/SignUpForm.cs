using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Construction_ERP__Management_System
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private readonly UcSignUp1 UcSignUp1 = new UcSignUp1();
        private readonly UcSignUp2 UcSignUp2 = new UcSignUp2();
        private readonly UcSignUp3 UcSignUp3 = new UcSignUp3();


        private void frmSignUp_Load(object sender, EventArgs e)
        {
            cmbSignUpAs.Items.Clear();
            cmbSignUpAs.Items.Add("Company");
            cmbSignUpAs.Items.Add("User");
            cmbSignUpAs.Items.Add("Vendor");
            cmbSignUpAs.SelectedIndex = 0;

        }

        private void LoadUC(UserControl uc)
        {
            panelMain.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uc);
            panelMain.Refresh();
        }

        private void cmbSignUpAs_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            int i = cmbSignUpAs.SelectedIndex;

            if (i == 0)
                LoadUC(new UcSignUp1());
            else if (i == 1)
                LoadUC(new UcSignUp2());
            else if (i == 2)
                LoadUC(new UcSignUp3());
            else
                MessageBox.Show("No match index: " + i);
        }
    }
}
