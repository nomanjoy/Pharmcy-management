using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_Application
{
    public partial class FormCreatAccount : Form
    {
        public FormCreatAccount()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormCreatAccount_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LogInPage lp = new LogInPage();
            lp.Show();
            Visible = false;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            Visible = false;
        }
    }
}
