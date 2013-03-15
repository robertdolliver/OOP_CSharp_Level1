using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _06_TryCatch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumber1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                decimal n1 = Convert.ToDecimal(txtNumber1.Text);
                decimal n2 = Convert.ToDecimal(txtNumber2.Text);

                decimal total = Add(n1,n2); //Call to Enterprise Code
                txtTotal.Text = total.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                decimal n1 = Convert.ToDecimal(txtNumber1.Text);
                decimal n2 = Convert.ToDecimal(txtNumber2.Text);

                decimal total = Divide(n1, n2); //Call to Enterprise Code
                txtTotal.Text = total.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                //Cleanup
                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }
        #region Math Routines

        public decimal Add(decimal num1, decimal num2)
        {
            decimal total = num1 + num2;
            return total;
        }
        public decimal Divide(decimal num1, decimal num2)
        {
            try
            {
                decimal total = num1 / num2;
                return total;
            }
            catch (DivideByZeroException)
            {
                throw new Exception("You cannot have a zero in the denominator");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        
        #endregion

        private void txtNumber1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());
          if (!char.IsDigit(e.KeyChar) &&  !char.IsControl(e.KeyChar))
            {
                e.Handled = true;//Prevents entry of Keystroke
                MessageBox.Show("Numbers Only Please");
            }
        }

 
    }
}
