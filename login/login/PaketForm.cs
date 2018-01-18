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
    public partial class PaketForm : Form
    {
        MySqlConnection conn = new MySqlConnection("server=localhost; UID=root; Pwd=; " +
           "database=db_laundry;");
        public PaketForm()
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
                string query = "select * from package";
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
            cmd.CommandText = "insert into package (_id, name, estimate) values ('" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            loadDataset();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var pilhrow = dataGridView1.SelectedRows[0];
            textBox1.Text = pilhrow.Cells["_id"].Value.ToString();
            textBox2.Text = pilhrow.Cells["name"].Value.ToString();
            textBox3.Text = pilhrow.Cells["estimate"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            MessageBox.Show("Data Berhasil Diupdate");
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("update package set name='" + textBox2.Text + "', estimate='" + textBox3.Text + "' where _id='" + textBox1.Text + "'");
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
            cmd.CommandText = ("delete from package where _id = '" + textBox1.Text + "'");
            cmd.ExecuteNonQuery();
            conn.Close();
            loadDataset();
        }
    }
}
