using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ADOdotNET
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void dataReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdoDataReader f = new AdoDataReader();
            f.MdiParent = this;
            f.Text = "ADO Data-Reader";
            f.Show();
        }

        private void dataSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdoDataSet f = new AdoDataSet();
            f.MdiParent = this;
            f.Text = "ADO Data-Set";
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
