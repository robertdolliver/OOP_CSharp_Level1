using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _01_MemoryManagement
{
    public partial class Main : Form
    {
        //Global Level
        public string strUserName = "MMouse";

        //Class Level Variables
        int inttotal;
        //double type specifier
        double dblTotal = 100.5;
        //decimal type specifier
        decimal decTotal = 100.5m;
        //float type specifier
        float fltTotal = 100.5f + 100.5f;

        //constant
        const decimal TAXRATE = .075m;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

           

        }

        private void Main_Load_1(object sender, EventArgs e)
        {
            txtProduct.Text = "Computer"; //Assign Property
            txtProduct.TextAlign = HorizontalAlignment.Center;

            //Procedure Levl Variables
            int num1; //declaration statement
            num1 = 400; //assignment statement

            int num2 = 100; //strongly typed

            inttotal = num1 + num2;
            //MessageBox Can only show string values
            MessageBox.Show(inttotal.ToString());
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtPrice.Focus();

            int num = 10;
            //Three ways to increment by One
           
            num++;

            num = num + 1;
            num += 1;
        }
    }
}
 