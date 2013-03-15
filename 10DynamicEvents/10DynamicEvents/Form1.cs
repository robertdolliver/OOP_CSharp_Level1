using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _10DynamicEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnMagic.Click += new EventHandler(StepOne);
        }

        private void StepOne(object sender, EventArgs e)
        {
            MessageBox.Show("Step One Complete!");
            btnMagic.Click -= StepOne; //Elimanate Step One
            btnMagic.Click += new EventHandler(StepTwo); //Add Step Two
            btnMagic.Text = "Step 2 Magic";
        }
        
        private void StepTwo(object sender, EventArgs e)
        {
            MessageBox.Show("Step Two Complete!");
            btnMagic.Click -= StepTwo;
            btnMagic.Text = "Finished";
            
        }
    }
}
