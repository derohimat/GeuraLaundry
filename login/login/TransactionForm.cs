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

    public partial class TransactionForm : Form
    {
        private List<PackageDao> listPackage = new List<PackageDao>();
        private List<TypeDao> listType = new List<TypeDao>();
        private List<CustomerDao> listCustomer = new List<CustomerDao>();
        private MySqlConnection mDbConnection;

        public TransactionForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            mDbConnection = new MySqlConnection("server=localhost;Database=db_laundry;username=root;password=;");
            mDbConnection.Open();

            string selectQueryType = "SELECT * FROM type";
            MySqlCommand commandType = new MySqlCommand(selectQueryType, mDbConnection);
            MySqlDataReader readerType = commandType.ExecuteReader();
            while (readerType.Read())
            {
                TypeDao item = new TypeDao
                {
                    ID = readerType.GetInt32("_id"),
                    Name = readerType.GetString("name"),
                    Price = readerType.GetInt32("price"),
                    Unit = readerType.GetString("unit")
                };

                listType.Add(item);
                comboBoxType.Items.Add(item.Name);
            }
            mDbConnection.Close();

            mDbConnection.Open();
            string selectQueryPackage = "SELECT * FROM package";
            MySqlCommand commandPackage = new MySqlCommand(selectQueryPackage, mDbConnection);
            MySqlDataReader readerPackage = commandPackage.ExecuteReader();
            while (readerPackage.Read())
            {
                PackageDao item = new PackageDao
                {
                    ID = readerPackage.GetInt32("_id"),
                    Name = readerPackage.GetString("name"),
                    Estimate = readerPackage.GetInt32("estimate")
                };

                listPackage.Add(item);
                comboBoxPackage.Items.Add(item.Name);
            }
            mDbConnection.Close();

            mDbConnection.Open();
            string selectQueryPelanggan = "SELECT * FROM customer";
            MySqlCommand commandCustomer = new MySqlCommand(selectQueryPelanggan, mDbConnection);
            MySqlDataReader readerCustomer = commandCustomer.ExecuteReader();
            while (readerCustomer.Read())
            {
                CustomerDao item = new CustomerDao
                {
                    ID = readerCustomer.GetInt32("_id"),
                    Name = readerCustomer.GetString("name"),
                    PhoneNumber = readerCustomer.GetString("phone_number"),
                    Address = readerCustomer.GetString("address")
                };

                listCustomer.Add(item);
                comboBoxCustomer.Items.Add(item.Name);
            }
            mDbConnection.Close();
        }

        private void comboBoxCustomer_SelectedIndexChanged(object sender,
        System.EventArgs e)
        {
            CustomerDao customerDao = listCustomer[comboBoxCustomer.SelectedIndex];

            textBoxPhoneNumber.Text = customerDao.PhoneNumber;
            textBoxAddress.Text = customerDao.Address;
        }
    }
}
