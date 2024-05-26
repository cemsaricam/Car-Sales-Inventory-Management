using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace _20200305010Project
{
    public partial class LoginForm : Form
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private MySqlDataAdapter adapter;
        private DataTable dataTable;

        public LoginForm()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            string connectionString = "Server=localhost;User ID=root;Password=;Database=20200305010";
            connection = new MySqlConnection(connectionString);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Kullanýcý adý ve þifre boþ olamaz.");
                return;
            }

            if (CheckLogin(username, password))
            {
                MessageBox.Show("Giriþ baþarýlý!");
                OpenMenuForm(); 
            }
            else
            {
                MessageBox.Show("Hatalý kullanýcý adý veya þifre.");
            }
        }
        private void OpenMenuForm()
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide(); 
        }

        private bool CheckLogin(string username, string password)
        {
            if (username == "adminn" && password == "12344") // database'e baðlanmadan çalýþtýrmak için.
            {
                return true;
            }

            string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
            command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            connection.Open();
            int count = Convert.ToInt32(command.ExecuteScalar());
            connection.Close();

            return count > 0;
        }
    }
}
