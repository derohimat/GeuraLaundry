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
    public partial class Form3 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; UID=root; Pwd=; " +
           "database=db_laundry;");
        public Form3()
        {
            InitializeComponent();
            loadDataset();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        public void loadDataset()
        {
            try
            {
                conn.Open();
                string query = "select * from user";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with error : " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            MessageBox.Show("Data Berhasil Ditambahkan");
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into user (user_id, username, password, firstname, lastname) values ('" + textBox5.Text + "','" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            loadDataset();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var pilhrow = dataGridView1.SelectedRows[0];
            textBox1.Text = pilhrow.Cells["username"].Value.ToString();
            textBox2.Text = pilhrow.Cells["password"].Value.ToString();
            textBox3.Text = pilhrow.Cells["firstname"].Value.ToString();
            textBox4.Text = pilhrow.Cells["lastname"].Value.ToString();
            textBox5.Text = pilhrow.Cells["user_id"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            MessageBox.Show("Data Berhasil Diupdate");
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("update user set username='" + textBox1.Text + "', password='" + textBox2.Text + "', firstname='" + textBox3.Text + "', lastname='" + textBox4.Text + "' where user_id='" + textBox5.Text + "'");
            cmd.ExecuteNonQuery();
            conn.Close();
            loadDataset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            MessageBox.Show("Data Berhasil Dihapus");
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("delete from user where user_id = '" + textBox5.Text + "'");
            cmd.ExecuteNonQuery();
            conn.Close();
            loadDataset();
        }
    }
}
