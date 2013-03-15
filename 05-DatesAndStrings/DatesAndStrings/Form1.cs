using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatesAndStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int num = 10;
            DateTime dtToday = DateTime.Now;
            txtCurrentDate.Text = dtToday.ToShortDateString();
            lblDateChoice.Text = dtToday.ToLongDateString();
            this.Text = dtToday.ToString("f");
        
            DateTime dt = DateTime.Now;
            DateTime dtPlus90 = dt.AddDays(90);
            txtPlus90.Text = dtPlus90.ToShortDateString();

            tabDateString.SelectTab(1);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDateChoice.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblDateChoice.Text = monthCalendar1.SelectionStart.ToLongDateString();
        }

        private void btnSplitName_Click(object sender, EventArgs e)
        {
            string fullName = txtEmployeeName.Text;
            int idx = fullName.IndexOf(" "); //Starts at Zero
            //int idx = fullName.IndexOf(" ",6); //Starts at Position Six

            string first = fullName.Substring(0, idx);
            //string last = fullName.Substring(idx+1);//If no length; assumes the rest
            string last = fullName.Substring(idx).Trim();

            txtFirstName.Text = first;
            txtLastName.Text = last;

        }

        private void btnStringFormat_Click(object sender, EventArgs  e)
        {
            string fullName = txtEmployeeName.Text;
            int age = 75;
            DateTime birth = Convert.ToDateTime("01/01/1925");
            decimal salary = 1250000;

            string info =
                string.Format("{0} is {1} years old, born on {2:D} and makes {3:c}",
                      fullName, age, birth, salary);
            MessageBox.Show(info);
        }

        private void tabPageStrings_Click(object sender, EventArgs e)
        {

        }



    }
}
