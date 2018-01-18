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
    public partial class MenuUtama : Form
    {
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void registrasiUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserForm newMDIChild = new UserForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void submenu4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaketForm newMDIChild = new PaketForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void ambilCucianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JenisLaundryForm newMDIChild = new JenisLaundryForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void submenu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm newMDIChild = new CustomerForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void submenu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransaksiForm newMDIChild = new TransaksiForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TransaksiForm newMDIChild = new TransaksiForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
