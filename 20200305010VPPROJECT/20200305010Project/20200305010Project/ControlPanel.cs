using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace _20200305010Project
{
    public partial class ControlPanel : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;

        public ControlPanel()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadProducts();
        }

        private void InitializeDatabase()
        {
            string connectionString = "Server=localhost;User ID=root;Password=;Database=20200305010"; 
            connection = new MySqlConnection(connectionString);
        }

        private void LoadProducts()
        {
            listView1.Items.Clear();

            string query = "SELECT * FROM products";
            command = new MySqlCommand(query, connection);

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["ID"].ToString());
                    item.SubItems.Add(reader["NAME"].ToString());
                    item.SubItems.Add(reader["BRAND"].ToString());
                    item.SubItems.Add(reader["QUANTITY"].ToString());

                    listView1.Items.Add(item);
                }

                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL hatası: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }
    }
}
