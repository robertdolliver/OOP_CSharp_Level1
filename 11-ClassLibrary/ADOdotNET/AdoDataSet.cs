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
    public partial class AdoDataSet : Form
    {
        public AdoDataSet()
        {
            InitializeComponent();
        }

        private void AdoDataSet_Load(object sender, EventArgs e)
        {
            DataTable stateData = GetStates();
            cboStates.DataSource = stateData;
            cboStates.DisplayMember = "StateName";
            cboStates.ValueMember = "StateCode";
            //cboStates.DataBind() for the Web
        }

        public DataTable GetStates()
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
            cmd.CommandText = "Select StateCode,StateName From States";

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

        public DataSet GetCustomersByState(string st)
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
            cmd.CommandText = "Select CustomerID,Name,State From Customers " +
                              "Where State = @State";
            cmd.Parameters.AddWithValue("@State",st);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            //DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                //da.Fill(dt);
                da.Fill(ds,"Customers");
                return ds;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
       
        private void cboStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dsCustomers = GetCustomersByState(cboStates.SelectedValue.ToString()); 
            grdCustomers.DataSource = dsCustomers.Tables["Customers"];
        }
    }
}
