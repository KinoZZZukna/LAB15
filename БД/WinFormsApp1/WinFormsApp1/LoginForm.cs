using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        private readonly string connectionString = "server=localhost;uid=root;pwd=root;database=family_food";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text.Trim();

            if (string.IsNullOrEmpty(firstName))
            {
                MessageBox.Show("Please enter your first and last name.");
                return;
            }

            int age = 0;

            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                string query = $"SELECT Age FROM User WHERE User_name = '{firstName}'";
                MySqlCommand command = new MySqlCommand(query, connection);
                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count == 0)
                {
                    MessageBox.Show("User not found in database.");
                    return;
                }

                query = $"SELECT Age FROM User WHERE User_name = '{firstName}'";
                command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    age = (int)reader["Age"];
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
                return;
            }

            if (age < 18)
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
            else
            {
                Form2 form2 = new Form2(firstName);
                form2.Show();
            }

            this.Hide();

        }
    }
}