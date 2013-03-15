using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ADOdotNET
{
    public partial class AdoDataReader : Form
    {
        public AdoDataReader()
        {
            InitializeComponent();
        }

        private void AdoDataReader_Load(object sender, EventArgs e)
        {

        }

        public SqlDataReader GetCustomerNames()
        {
            string connectionString =
               @"Data Source=.\;Initial Catalog=MMABooks;Integrated Security=True";

            //Build Pipe
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connectionString;

            //Build a Vehicle
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text; //Default Status
            cmd.CommandText = "Select Name From Customers";

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //conn.Close();
            }
        }

        private void btnGetCustomerNames_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader customers = GetCustomerNames();
                while (customers.Read())
                {
                    lstCustomers.Items.Add(customers["Name"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
