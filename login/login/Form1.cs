using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace login
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; UID=root; Pwd=; " +
           "database=db_laundry;");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select username, password from user where username='" + username + "' and password = '" + password + "' ";
            MySqlDataReader datareader = cmd.ExecuteReader();
            if (datareader.Read())
            {
                MessageBox.Show("Login berhasil", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 main = new Form2();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username dan Password tidak cocok", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox1.Focus();
            }
            conn.Close();
        }
    }
}
