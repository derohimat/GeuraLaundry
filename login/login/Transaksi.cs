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
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;Database=db_laundry;username=root;password=;");
            string selectQuery = "SELECT * FROM type"; connection.Open();

            MySqlCommand command = new MySqlCommand(selectQuery, connection);

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBox3.Items.Add(reader.GetString("name"));
            }

            connection.Close();
        }
    }
}
