using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace _20200305010Project
{
    public partial class AdminPanel : Form
    {
        private string connectionString = "Server=localhost;User ID=root;Password=;Database=20200305010";
        

        public AdminPanel()
        {
            InitializeComponent();
            LoadProducts(); 
        }

        private void LoadProducts()
        {
            listViewProducts.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
               
                string query = "SELECT * FROM products";
                MySqlCommand command = new MySqlCommand(query, connection);

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

                        listViewProducts.Items.Add(item);
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
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string id = textid.Text;
            string name = textName.Text;
            string brand = textBrand.Text;
            string quantity = textQuantity.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(id) || string.IsNullOrEmpty(brand) || string.IsNullOrEmpty(quantity))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO products (ID,NAME, BRAND, QUANTITY) VALUES (@id,@name, @brand, @quantity)";
                MySqlCommand insertCommand = new MySqlCommand(query, connection);
                insertCommand.Parameters.AddWithValue("@id", id);
                insertCommand.Parameters.AddWithValue("@name", name);
                insertCommand.Parameters.AddWithValue("@brand", brand);
                insertCommand.Parameters.AddWithValue("@quantity", quantity);

                try
                {
                    connection.Open();
                    int result = insertCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Ürün başarıyla eklendi.");
                        LoadProducts(); 
                    }
                    else
                    {
                        MessageBox.Show("Ürün eklenirken bir hata oluştu.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL hatası: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            string id = textid.Text;
            string name = textName.Text;
            string brand = textBrand.Text;
            string quantity = textQuantity.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Lütfen bir ürün seçin.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE products SET NAME = @name, BRAND = @brand, QUANTITY = @quantity WHERE ID = @id";
                MySqlCommand updateCommand = new MySqlCommand(query, connection);
                updateCommand.Parameters.AddWithValue("@name", name);
                updateCommand.Parameters.AddWithValue("@brand", brand);
                updateCommand.Parameters.AddWithValue("@quantity", quantity);
                updateCommand.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    int result = updateCommand.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Ürün başarıyla güncellendi.");
                        LoadProducts(); 
                    }
                    else
                    {
                        MessageBox.Show("Ürün güncellenirken bir hata oluştu.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL hatası: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            string id = textid.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Lütfen bir ürün seçin.");
                return;
            }

            if (MessageBox.Show("Seçilen ürünü silmek istediğinize emin misiniz?", "Ürünü Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "DELETE FROM products WHERE ID = @id";
                    MySqlCommand deleteCommand = new MySqlCommand(query, connection);
                    deleteCommand.Parameters.AddWithValue("@id", id);

                    try
                    {
                        connection.Open();
                        int result = deleteCommand.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Ürün başarıyla silindi.");
                            LoadProducts(); 
                        }
                        else
                        {
                            MessageBox.Show("Ürün silinirken bir hata oluştu.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("MySQL hatası: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                }
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
