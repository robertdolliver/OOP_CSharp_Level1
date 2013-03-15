using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _07ADOdotNET
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void dataReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADODataReader f = new ADODataReader();
            f.MdiParent = this;
            f.Text = "Data Reader Demo";
            f.Show();
        }

        private void dataSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADODataSet f = new ADODataSet();
            f.MdiParent = this;
            f.Text = "ADO DataSet Demo";
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dragDropDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DragDropData f = new DragDropData();
            f.MdiParent = this;
            f.Text = "Dragging in Data";
            f.Show();
        }
    }
}
