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
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var pilhrow = dataGridView1.SelectedRows[0];
            textId.Text = pilhrow.Cells["_id"].Value.ToString();
            textBoxAddress.Text = pilhrow.Cells["address"].Value.ToString();
            textStatus.Text = pilhrow.Cells["status"].Value.ToString();
            textBoxPhoneNumber.Text = pilhrow.Cells["phone_number"].Value.ToString();
            textWeight.Text = pilhrow.Cells["weight"].Value.ToString();
            
            String name = pilhrow.Cells["customer"].Value.ToString();
            comboBoxCustomer.SelectedIndex = comboBoxCustomer.FindStringExact(name);

            String type = pilhrow.Cells["type"].Value.ToString();
            comboBoxType.SelectedIndex = comboBoxType.FindStringExact(type);

            String package = pilhrow.Cells["package"].Value.ToString();
            comboBoxPackage.SelectedIndex = comboBoxPackage.FindStringExact(package);
        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            loadData();
            loadDataset();
        }

        public void loadDataset()
        {
            try
            {
                mDbConnection.Open();
                string query = "SELECT a._id, b.name as customer, c.name as type, d.name as package, " +
                    " a.weight, b.phone_number, b.address,  (CASE WHEN a.status = 0 THEN 'Proses' ELSE 'Selesai' END) as status " +
                    "FROM transaction a JOIN customer b ON(a.customer_id = b._id) JOIN type c ON(a.type_id= c._id) " +
                    "JOIN package d ON(a.package_id = d._id)";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, mDbConnection))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                mDbConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed with error : " + ex.Message);
            }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mDbConnection.Open();
            MessageBox.Show("Data Berhasil Ditambahkan");
            MySqlCommand cmd = mDbConnection.CreateCommand();

            int selectedCustomerId = listCustomer[comboBoxCustomer.SelectedIndex].ID;
            int selectedPackageId = listPackage[comboBoxPackage.SelectedIndex].ID;
            int selecteTypeId = listType[comboBoxType.SelectedIndex].ID;

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO `transaction` (`_id`, `package_id`, `type_id`, `user_id`, `customer_id`, `status`, `weight`) values " +
                "('" + textId.Text + "','" + selectedPackageId + "', '" + selecteTypeId +"', '" + "1" + "', '"
                + selectedCustomerId + "', '" + "0" + "', '" + textWeight.Text + "')";
            cmd.ExecuteNonQuery();
            mDbConnection.Close();
            loadDataset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            mDbConnection.Open();
            MessageBox.Show("Data Berhasil Dihapus");
            MySqlCommand cmd = mDbConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("delete from transaction where _id = '" + textId.Text + "'");
            cmd.ExecuteNonQuery();
            mDbConnection.Close();
            loadDataset();
        }
    }
}
