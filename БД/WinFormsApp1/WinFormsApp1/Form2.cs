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
    public partial class Form2 : Form
    {
        private readonly string connectionString = "server=localhost;uid=root;pwd=root;database=family_food";
        public Form2(string user)
        {
            InitializeComponent();
            UserInfo(user);
            Load(user);
        }
        private void UserInfo(string userName)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                // Get the user's ID
                int userId = DatabaseHelper.GetUserId(userName);
                int userAge = DatabaseHelper.GetUserAge(userId);
                string userGender = DatabaseHelper.GetUserGender(userId);
                var userDateOfBirth = DatabaseHelper.GetUserDateOfBirth(userId);
                int userHeight = DatabaseHelper.GetUserHeight(userId);
                int userWeight = DatabaseHelper.GetUserWeight(userId);
                string userActivityLevel = DatabaseHelper.GetUserActivityLevel(userId);

                // Get the user's diet
                string query = $"SELECT d.Diet_Name FROM Diet d JOIN User_Diet ud ON d.Diet_ID = ud.Diet_ID WHERE ud.User_ID = {userId}";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    string dietName = (string)reader["Diet_Name"];
              
                    dietLabel.Text = "Ваша диета: " + dietName;

                    userNameLabel.Text = "Имя: " + userName + " Пол: " + userGender + " Возраст: " + userAge + " Дата рождения: " + userDateOfBirth + " Рост: " + userHeight + " Вес: " + userWeight + " Уровень активности: " + userActivityLevel;
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while connecting to the database: " + ex.Message);
            }
        }
        private void Load(string userName)
        {
            int userId = DatabaseHelper.GetUserId(userName);
            // Перед выводом информации в DataGridView мы должны получить ID диеты пользователя
            string userDietQuery = $"SELECT diet_id FROM User_Diet WHERE user_id = {userId}";
            int dietId = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand(userDietQuery, connection);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    dietId = (int)reader["diet_id"];
                }

                reader.Close();
            }

            // Получаем информацию о продуктах, используемых в диете
            string productsQuery = $"SELECT p.Product_name, pm.quantity, p.Calories, p.Proteins, p.Fats, p.Carbohydrates, p.Category, p.Weight FROM Products p JOIN Product_Menu pm ON p.product_id = pm.product_id WHERE pm.menu_id IN (SELECT menu_id FROM Diet_Menu WHERE diet_id = {dietId})";

            DataTable productsTable = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter(productsQuery, connection);
                adapter.Fill(productsTable);
            }

            // Получаем информацию о меню диеты
            string menuQuery = $"SELECT m.Menu_name, dm.quantity FROM Menu m JOIN Diet_Menu dm ON m.menu_id = dm.menu_id WHERE dm.diet_id = {dietId}";

            DataTable menuTable = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter(menuQuery, connection);
                adapter.Fill(menuTable);
            }

            // Создаем таблицу для вывода информации
            DataTable outputTable = new DataTable();
            outputTable.Columns.Add("Product Name");
            outputTable.Columns.Add("Quantity");
            outputTable.Columns.Add("Calories");
            outputTable.Columns.Add("Proteins");
            outputTable.Columns.Add("Fats");
            outputTable.Columns.Add("Carbohydrates");
            outputTable.Columns.Add("Category");
            outputTable.Columns.Add("Weight");

            // Заполняем таблицу с информацией о продуктах
            foreach (DataRow row in productsTable.Rows)
            {
                string productName = (string)row["Product_name"];
                string quantity = (string)row["quantity"];
                int calories = (int)row["Calories"];
                int proteins = (int)row["Proteins"];
                int fats = (int)row["Fats"];
                int carbohydrates = (int)row["Carbohydrates"];
                string category = (string)row["Category"];
                int weight = (int)row["Weight"];

                outputTable.Rows.Add(productName, quantity, calories, proteins, fats, carbohydrates, category, weight);
            }

            // Заполняем таблицу с информацией о меню
            foreach (DataRow row in menuTable.Rows)
            {
                string menuName = (string)row["Menu_name"];
                int quantity = (int)row["quantity"];

                outputTable.Rows.Add(menuName, quantity, "", "", "", "", "", "");
            }

            // Выводим таблицу с информацией в DataGridView
            dataGridView1.DataSource = outputTable;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
