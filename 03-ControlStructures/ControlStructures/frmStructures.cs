using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace ControlStructures
{
    public partial class frmStructures : Form
    {
        public frmStructures()
        {
            InitializeComponent();
        }

        private void frmStructures_Load(object sender, EventArgs e)
        {
            //Meat
            cboChoices.Items.Add("Beef");
            cboChoices.Items.Add("Chicken");
            //Dairy
            cboChoices.Items.Add("Cheese");
            cboChoices.Items.Add("Butter");
            //Beverage
            cboChoices.Items.Add("Coffee");
            cboChoices.Items.Add("Wine");
        }

        private void cboChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void btnIfElse_Click(object sender, EventArgs e)
        {
            //empty string
            string result = "";

            if (cboChoices.Text == "Cheese" || cboChoices.Text == "Butter")
            {
                result += cboChoices.Text + " is Dairy"; 
            }
            else if (cboChoices.Text == "Beef" || cboChoices.Text == "Chicken")
            {
                result += cboChoices.Text + " is Meat";
            }
            else if (cboChoices.Text == "Coffee" || cboChoices.Text == "Wine")
            {
                result += cboChoices.Text + " is Beverage";
            }
            else //Otherwise - Catch all
            {
                result += cboChoices.Text + " is NOT one of our Products";
            }
            
            lstResults.Items.Add(result);
        }

        private void btnSwitchCase_Click(object sender, EventArgs e)
        {
            string result = "";
            //"!" always means NOT
            if (cboChoices.Text != "")
            {


                switch (cboChoices.Text.ToUpper())
                {
                    case "CHEESE": //':' End Single Evaluation
                    case "BUTTER":
                        result = cboChoices.Text + " is Dairy";
                        break;
                    case "BEEF":
                    case "CHICKEN":
                        result = cboChoices.Text + " is Meat";
                        break;
                    case "COFFEE":
                    case "WINE":
                        result = cboChoices.Text + " is Beverage";
                        break;
                    default:
                        result = cboChoices.Text + " is NOT Our Product";
                        break;

                }
                lstResults.Items.Add(result);

            }
            else
            {
                MessageBox.Show("Please Enter a Product");
            }
            
            lstResults.SelectedIndex = lstResults.Items.Count - 1;

            cboChoices.Focus();
            cboChoices.SelectAll(); //Windows Only

        }//End Event Procedure

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtIterations.Text);
            int i = 1;

            //clear list items
            lstResults.Items.Clear();
            while (i<=num)
            {
                //statements
                lstResults.Items.Add("While #" + i);
                i++;
            }
            i--;
            do
            {
               lstResults.Items.Add("While #" + i);
               i--;
            } while (i>=1);

            lstResults.SelectedIndex = lstResults.Items.Count - 1;
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtIterations.Text);

            //clear list items
            lstResults.Items.Clear();
            //   Start      End       Increment
            for ( int i = 1; i <= num; i++)
            {
                lstResults.Items.Add("For #" + i);
                Debug.WriteLine("For #" + i);
            }
            for (int i = num; i >= 1; i--)
            {
                lstResults.Items.Add("For #" + i);
                Debug.WriteLine("For #" + i);

            }
               lstResults.SelectedIndex = lstResults.Items.Count - 1;
        }

        private void btnBreakContinue_Click(object sender, EventArgs e)
        {
            //Clear List Items
            lstResults.Items.Clear();
            //   Start      End      Increment
            for (int i = 1; i <= 10; i++)
            {
                //if (i == 5)
                //{
                //    break;
                //}
                if (i==3 || i==7)
                {
                    continue; //Re-loop
                }
                lstResults.Items.Add("For #" + i);
            }

            lstResults.SelectedIndex = lstResults.Items.Count - 1;
        }
 
    }
}
