using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void registrasiUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newMDIChild = new Form3();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void submenu4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 newMDIChild = new Form4();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void ambilCucianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 newMDIChild = new Form5();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void submenu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 newMDIChild = new Form6();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void submenu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaksi newMDIChild = new Transaksi();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
