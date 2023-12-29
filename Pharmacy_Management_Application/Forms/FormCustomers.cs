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

namespace Pharmacy_Management_Application.Forms
{
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            SqlConnection con = new System.Data.SqlClient.SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\ProjectC#\Pharmacy_Management_Application\PharmacyDB.mdf;Integrated Security=True");
            con.Open();



            SqlCommand sq1 = new SqlCommand("select * from Customer", con);
            DataTable dt = new DataTable();



            SqlDataReader sdr = sq1.ExecuteReader();
            dt.Load(sdr);



            GridViewCustomer.DataSource = dt;
            con.Close();
        }

     

       

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new System.Data.SqlClient.SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\ProjectC#\Pharmacy_Management_Application\PharmacyDB.mdf;Integrated Security=True");
            con.Open();


            SqlCommand sq1 = new SqlCommand("update Customer set  Name=@Name, Email=@Email, Address=@Address, Phone_number=@Phone_number where Customer_ID=@Customer_ID", con);
            sq1.Parameters.AddWithValue("@Customer_ID", int.Parse(tboxCustomerID.Text));
            sq1.Parameters.AddWithValue("@Name", tboxName.Text);
            sq1.Parameters.AddWithValue("@Email", tboxEmail.Text);
            sq1.Parameters.AddWithValue("@Address", tboxAddress.Text);
            sq1.Parameters.AddWithValue("@Phone_number", tboxPhonenumber.Text);
            sq1.ExecuteNonQuery();
            con.Close();



            MessageBox.Show("Customer Info Updated");
        }

        private void GridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new System.Data.SqlClient.SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\ProjectC#\Pharmacy_Management_Application\PharmacyDB.mdf;Integrated Security=True");
            con.Open();


            SqlCommand sq1 = new SqlCommand("insert into Customer(Customer_ID,Name,Email,Address,Phone_number) values(@Customer_ID,@Name,@Email,@Address,@Phone_number)", con);
            sq1.Parameters.AddWithValue("@Customer_ID", int.Parse(tboxCustomerID.Text));
            sq1.Parameters.AddWithValue("@Name",tboxName.Text);
            sq1.Parameters.AddWithValue("@Email", tboxEmail.Text);
            sq1.Parameters.AddWithValue("@Address", tboxAddress.Text);
            sq1.Parameters.AddWithValue("@Phone_number", tboxPhonenumber.Text);
            sq1.ExecuteNonQuery();
            con.Close();



            MessageBox.Show("Customer Info Added");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            SqlConnection con = new System.Data.SqlClient.SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\ProjectC#\Pharmacy_Management_Application\PharmacyDB.mdf;Integrated Security=True");
            con.Open();


            SqlCommand sq1 = new SqlCommand("select * from Customer", con);
            SqlDataAdapter ds = new SqlDataAdapter(sq1);
            DataTable dt = new DataTable();
            ds.Fill(dt);



            GridViewCustomer.DataSource = dt;
            con.Close();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            SqlConnection con = new System.Data.SqlClient.SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\ProjectC#\Pharmacy_Management_Application\PharmacyDB.mdf;Integrated Security=True");
            con.Open();


            SqlCommand sq1 = new SqlCommand("delete from Customer where Customer_ID=@Customer_ID", con);
            sq1.Parameters.AddWithValue("@Customer_ID", int.Parse(tboxCustomerID.Text));

            sq1.ExecuteNonQuery();
            con.Close();



            MessageBox.Show("Customer Info Removed");

        }
    }
}
