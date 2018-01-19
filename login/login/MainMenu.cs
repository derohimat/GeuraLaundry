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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void userRegisterMenuItem_Click(object sender, EventArgs e)
        {
            UserForm newMDIChild = new UserForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void packageMenuItem_Click(object sender, EventArgs e)
        {
            PackageForm newMDIChild = new PackageForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void typeMenuItem_Click(object sender, EventArgs e)
        {
            TypeForm newMDIChild = new TypeForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void customerMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm newMDIChild = new CustomerForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void transactionMenuItem_Click(object sender, EventArgs e)
        {
            TransactionForm newMDIChild = new TransactionForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            TransactionForm newMDIChild = new TransactionForm();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void logOutMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
