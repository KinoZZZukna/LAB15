using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        private string connectionString = "server=localhost;database=test;user=root;password=root;";

        public Form4()
        {
            InitializeComponent();
            LoadProductsToDataGridView();
            LoadUsersToDataGridView();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            LoadProductsToDataGridView();
            LoadUsersToDataGridView();
        }

        private void LoadProductsToDataGridView()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Products";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private int GetNextProductId()
        {
            int nextProductId = 1;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT MAX(product_id) FROM Products";
                MySqlCommand command = new MySqlCommand(query, connection);
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    nextProductId = Convert.ToInt32(result);
                }
            }

            return nextProductId + 1;
        }

        private void AddProductToDatabase(string productName, int calories, int proteins, int fats, int carbohydrates, string category, int weight)
        {
            int productId = GetNextProductId();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Products (product_id, Product_name, Calories, Proteins, Fats, Carbohydrates, Category, Weight) " +
                               "VALUES (@ProductId, @ProductName, @Calories, @Proteins, @Fats, @Carbohydrates, @Category, @Weight)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductId", productId);
                command.Parameters.AddWithValue("@ProductName", productName);
                command.Parameters.AddWithValue("@Calories", calories);
                command.Parameters.AddWithValue("@Proteins", proteins);
                command.Parameters.AddWithValue("@Fats", fats);
                command.Parameters.AddWithValue("@Carbohydrates", carbohydrates);
                command.Parameters.AddWithValue("@Category", category);
                command.Parameters.AddWithValue("@Weight", weight);
                command.ExecuteNonQuery();
            }
        }
        private void DeleteProductFromDatabase(int productId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Удаляем продукт из базы данных
                string deleteQuery = "DELETE FROM Products WHERE product_id = @ProductId";
                MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@ProductId", productId);
                deleteCommand.ExecuteNonQuery();

                // Обновляем значения product_id в таблице
                string updateQuery = "UPDATE Products SET product_id = product_id - 1 WHERE product_id > @ProductId";
                MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@ProductId", productId);
                updateCommand.ExecuteNonQuery();
            }
        }
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            string productName = textBoxProductName.Text;
            int calories = Convert.ToInt32(textBoxCalories.Text);
            int proteins = Convert.ToInt32(textBoxProteins.Text);
            int fats = Convert.ToInt32(textBoxFats.Text);
            int carbohydrates = Convert.ToInt32(textBoxCarbohydrates.Text);
            string category = textBoxCategory.Text;
            int weight = Convert.ToInt32(textBoxWeight.Text);

            AddProductToDatabase(productName, calories, proteins, fats, carbohydrates, category, weight);
            LoadProductsToDataGridView();
        }
        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["product_id"].Value);
                DeleteProductFromDatabase(productId);
                LoadProductsToDataGridView();
            }
        }
        private void LoadUsersToDataGridView()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM User";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView2.DataSource = dataTable;
            }
        }
        private void UpdateUserAge()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string updateQuery = "UPDATE User SET Age = Age + 1";
                    MySqlCommand command = new MySqlCommand(updateQuery, connection);
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("User age updated successfully.");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("An error occurred while updating user age: " + ex.Message);
                }
            }
        }

        private void buttonUpdateUserAge_Click(object sender, EventArgs e)
        {
            UpdateUserAge();
            LoadUsersToDataGridView();
        }

    }
}
