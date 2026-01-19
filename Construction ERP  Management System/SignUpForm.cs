using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


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
    }
}
