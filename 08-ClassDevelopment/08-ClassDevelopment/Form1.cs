using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic; //.net 2.0
using System.Collections; //ArrayList .net 1.0

namespace _08_ClassDevelopment
{
    public partial class Form1 : Form
    {
        List<Employee> employees = new List<Employee>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Static Classes
            decimal total = Statistics.Add(10, 20);
            //MessageBox.Show(total.ToString());

            try
            {
                //Object Classes
                Employee emp1 = new Employee();
                emp1.EmployeeID = 100;
                emp1.FirstName = "Mickey";
                emp1.LastName = "Mouse";
                emp1.HireDate = Convert.ToDateTime("03/14/2013");

                Employee emp2 = new Employee();
                emp2.EmployeeID = 200;
                emp2.FirstName = "Donald";
                emp2.LastName = "Duck";
                emp2.HireDate = DateTime.Now.Date;

                //MessageBox.Show(emp2.EmployeeInfo("\n"));
                employees.Add(emp1);
                employees.Add(emp2);
                employees.Add(new Employee
                    (300, "Minnie", "Mouse", Convert.ToDateTime("03/07/2001")));
                dgvEmployee.DataSource = employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnGetSales_Click(object sender, EventArgs e)
        {
            decimal total = Employee.EmployeeSales(100);
            MessageBox.Show(total.ToString("c"));
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            string[] names = { "Mickey", "Donald", "Pluto", "Goofy" };
            //lstArrays.DataSource = names;

            //Loosely Typed Collection Container .net 1.0
            ArrayList numberList = new ArrayList();
            numberList.Add(10);
            numberList.Add("10");
            numberList.Add(10.5);
            numberList.Add(new TextBox());

            //Strongly Typed Collection Container "Collections.Generic" .net 2.0
            List<int> genericNumbers = new List<int>();
            genericNumbers.Add(10);
            genericNumbers.Add(100);
            genericNumbers.Add(200);
            genericNumbers.Add(50);
            genericNumbers.Sort();
            lstArrays.DataSource = genericNumbers;
        }

        private void btnLINQ_Click(object sender, EventArgs e)
        {
            var num1 = 10;
            var num2 = 10.5;
            var num3 = 10.5m;
            //MessageBox.Show(num3.GetType().ToString());

            int[] numbers = { 100, 10, 25, 15, 5, 50, 25, 40 };
            var subNumbers = from n in numbers
                             where n <= 25
                             orderby n descending
                             select n;
            lstArrays.DataSource = null;
            lstArrays.DataSource = subNumbers.ToList();
        }

        private void btnLINQEmployees_Click(object sender, EventArgs e)
        {
            var newList = from emp in employees
                          orderby emp.LastName
                          select new
                          {
                              emp.EmployeeID,
                              emp.EmployeeName,
                              DateHired = emp.HireDate.ToLongDateString(),
                              Info = emp.FullName() + " - " + emp.GetType().ToString(),
                          };
           
            dgvEmployee.DataSource = newList.ToList();
        }
    }
}
