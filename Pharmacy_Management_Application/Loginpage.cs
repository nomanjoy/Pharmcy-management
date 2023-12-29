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
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCreatAccount ca = new FormCreatAccount();
            ca.Show();
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            Visible = false;
        }

        private void btnAdminLogIn_Click(object sender, EventArgs e)
        {
            Admin_Log_In al = new Admin_Log_In();
            al.Show();
            Visible = false;
        }
    }
}
