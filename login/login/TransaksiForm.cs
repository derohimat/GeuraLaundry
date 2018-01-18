using MySql.Data.MySqlClient;
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
    public partial class TransaksiForm : Form
    {
        public TransaksiForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;Database=db_laundry;username=root;password=;");
            connection.Open();

            string selectQueryType = "SELECT * FROM type";
            
            MySqlCommand commandType = new MySqlCommand(selectQueryType, connection);

            MySqlDataReader readerType = commandType.ExecuteReader();

            while (readerType.Read())
            {
                comboBox2.Items.Add(readerType.GetString("name"));
            }

            connection.Close();

            connection.Open();
            string selectQueryPaket = "SELECT * FROM package";
            
            MySqlCommand commandPaket = new MySqlCommand(selectQueryPaket, connection);

            MySqlDataReader readerPaket = commandPaket.ExecuteReader();

            while (readerPaket.Read())
            {
                comboBox3.Items.Add(readerPaket.GetString("name"));
            }

            connection.Close();

            connection.Open();
            string selectQueryPelanggan = "SELECT * FROM customer";

            MySqlCommand commandPelanggan = new MySqlCommand(selectQueryPelanggan, connection);

            MySqlDataReader readerPelanggan = commandPelanggan.ExecuteReader();

            while (readerPelanggan.Read())
            {
                comboBox1.Items.Add(readerPelanggan.GetString("name"));
            }

            connection.Close();
        }
    }
}
