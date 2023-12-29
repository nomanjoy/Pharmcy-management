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

namespace Pharmacy_Management_Application
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {
            SqlConnection con = new System.Data.SqlClient.SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\ProjectC#\Pharmacy_Management_Application\PharmacyDB.mdf;Integrated Security=True");
            con.Open();



            SqlCommand sq1 = new SqlCommand("select * from Products_Management", con);
            DataTable dt = new DataTable();



            SqlDataReader sdr = sq1.ExecuteReader();
            dt.Load(sdr);



            GridViewProducts.DataSource = dt;
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new System.Data.SqlClient.SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\ProjectC#\Pharmacy_Management_Application\PharmacyDB.mdf;Integrated Security=True");
            con.Open();


            SqlCommand sq1 = new SqlCommand("insert into Products_Management(Product_ID,Product_Name,Catagory,Price,Quantity,Description) values(@Product_ID,@Product_Name,@Catagory,@Price,@Quantity,@Description)", con);
            sq1.Parameters.AddWithValue("@Product_ID", int.Parse(tboxProductID.Text));
            sq1.Parameters.AddWithValue("@Product_Name", tboxProductName.Text);
            sq1.Parameters.AddWithValue("@Catagory", tboxCatagory.Text);
            sq1.Parameters.AddWithValue("@Price", tboxPrice.Text);
            sq1.Parameters.AddWithValue("@Quantity", tboxQuantity.Text);
            sq1.Parameters.AddWithValue("@Description", tboxDescription.Text);
            sq1.ExecuteNonQuery();
            con.Close();



            MessageBox.Show("Product Info Added");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            SqlConnection con = new System.Data.SqlClient.SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\ProjectC#\Pharmacy_Management_Application\PharmacyDB.mdf;Integrated Security=True");
            con.Open();


            SqlCommand sq1 = new SqlCommand("delete from Products_Management where Product_ID=@Product_ID", con);
            sq1.Parameters.AddWithValue("@Product_ID", int.Parse(tboxProductID.Text));

            sq1.ExecuteNonQuery();
            con.Close();



            MessageBox.Show("Product Info Removed");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            SqlConnection con = new System.Data.SqlClient.SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\ProjectC#\Pharmacy_Management_Application\PharmacyDB.mdf;Integrated Security=True");
            con.Open();


            SqlCommand sq1 = new SqlCommand("select * from Products_Management", con);
            SqlDataAdapter ds = new SqlDataAdapter(sq1);
            DataTable dt = new DataTable();
            ds.Fill(dt);



            GridViewProducts.DataSource = dt;
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new System.Data.SqlClient.SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\ProjectC#\Pharmacy_Management_Application\PharmacyDB.mdf;Integrated Security=True");
            con.Open();


            SqlCommand sq1 = new SqlCommand("update Products_Management set  Product_Name=@Product_Name, Catagory=@Catagory, Price=@Price, Quantity=@Quantity where Product_ID=@Product_ID", con);
            sq1.Parameters.AddWithValue("@Product_ID", int.Parse(tboxProductID.Text));
            sq1.Parameters.AddWithValue("@Product_Name", tboxProductName.Text);
            sq1.Parameters.AddWithValue("@Catagory", tboxCatagory.Text);
            sq1.Parameters.AddWithValue("@Price", tboxPrice.Text);
            sq1.Parameters.AddWithValue("@Quantity", tboxQuantity.Text);
            sq1.Parameters.AddWithValue("@Description", tboxDescription.Text);
            sq1.ExecuteNonQuery();
            con.Close();



            MessageBox.Show("Product Info Updated");
        }
    }
}
