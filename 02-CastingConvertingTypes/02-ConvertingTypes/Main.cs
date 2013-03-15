using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _02_ConvertingTypes
{
    public partial class Main : Form
    {
        //Global or Application Level
        public string strUserName = "MMouse";

        //Class Level Variables
        const decimal TAXRATE = .075m;
         
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            double total;
            decimal n1 = 100.5m;
            decimal n2 = 100;

            //C# Way
            double n3 = (double)n1;
            //Framework Way
            total = Convert.ToDouble(n1 + n2);
           

            //MessageBox.Show(total.ToString());


            string strTotal = "10" + "10";
            int intTotal = 10 + 10;

            txtTaxRate.Text = TAXRATE.ToString("p1");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal price = Convert.ToDecimal(txtPrice.Text);
            int qty = Convert.ToInt32(txtQuantity.Text);

            decimal decPrice = price * qty;
            decimal decTaxable = decPrice * TAXRATE;
            decimal decTotalPrice = decPrice + decTaxable;

            txtTotal.Text = decTotalPrice.ToString("c");

            string msg = strUserName + "\n" + 
                txtProduct.Text + "\n" + 
                decTotalPrice.ToString("c");
            MessageBox.Show(msg);
            
            //@ ignores all "\" in the string
            string path = @"C:\Data";
        }

        private void txtTaxRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNullValues_Click(object sender, EventArgs e)
        {
            int? num1 = 10;

            //int? num1 = null;
            if (num1.HasValue == true)
            {
               MessageBox.Show(num1.Value.ToString());
            }
            else
            {
                MessageBox.Show("Contains a Null Value");
            }
            
            
            
        }

    }

}
