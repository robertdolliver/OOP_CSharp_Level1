using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _08ClassDevelopment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Static Classes
            //Math.Sqrt(9); 
            decimal total = Statistics.Add(10, 20);

            try
            {
                //Object Classes (default)
                //DataTable dt = new DataTable();
                Employee emp1 = new Employee();
                emp1.EmployeeID = 100;

                emp1.EmployeeID = 100;
                emp1.FirstName = "Mickey";
                emp1.LastName = "Mouse";
                emp1.Hiredate = Convert.ToDateTime("03/14/2015");

                MessageBox.Show(emp1.LastName + " - " + emp1.Hiredate.ToLongDateString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
