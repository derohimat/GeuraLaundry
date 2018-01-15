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
    public partial class Form6 : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; UID=root; Pwd=; " +
           "database=db_laundry;");
        public Form6()
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
                string query = "select * from customer";
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
            cmd.CommandText = "insert into customer (_id, name, phone_number, address) values ('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            loadDataset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            MessageBox.Show("Data Berhasil Diupdate");
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("update type set name='" + textBox2.Text + "', phone_number='" + textBox3.Text + "', address='" + textBox4.Text + "' where _id='" + textBox1.Text + "'");
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
            cmd.CommandText = ("delete from customer where _id = '" + textBox1.Text + "'");
            cmd.ExecuteNonQuery();
            conn.Close();
            loadDataset();
        }
    }
}
