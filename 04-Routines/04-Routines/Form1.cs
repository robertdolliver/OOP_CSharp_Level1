using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _04_Routines
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnVoidSubNoArgument_Click(object sender, EventArgs e)
        {
            this.subSayHello(); //Invoke subSayHello
        }

        private void btnVoidSubWithArgument_Click(object sender, EventArgs e)
        {
            //Use the Overloaded Version of subSayHello
            subSayHello(txtName1.Text);
            
        }

        private void btnTypedFunctionNoArgument_Click(object sender, EventArgs e)
        {
            string result = fnSayHello();
            MessageBox.Show(result);
            this.Text = result;
        }

        private void btnTypedFunctionWithArgument_Click(object sender, EventArgs e)
        {
            //Use the Overloaded Version of fnSayHello
            MessageBox.Show(fnSayHello(txtName2.Text));
            this.Text = fnSayHello(txtName2.Text);
        }

        /// <summary>
        /// Puts 'Hello World' in a MessageBox
        /// </summary>
        private void subSayHello()
        {
            MessageBox.Show("Hello World");
        }
        /// <summary>
        /// Accepts a Name to say Hello, in a MessageBox
        /// </summary>
        /// <param name="name"></param>
        private void subSayHello(string name)
        {
            MessageBox.Show("Hello " + name);
            
        }

        private string fnSayHello()
        {
            return "Hello World";
        }

        private string fnSayHello(string name)
        {
            return "Hello " + name;
        }


        private void form1_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Button.ToString());
        }
    }
}
