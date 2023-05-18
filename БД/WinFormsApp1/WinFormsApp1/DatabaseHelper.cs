using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    internal class DatabaseHelper
    {
        private static string connectionString = "server=localhost;database=family_food;user=root;password=root;";
        public static int GetUserId(string userName)
        {
            int userId = -1;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT user_id FROM User WHERE User_name = '{userName}'";
                MySqlCommand command = new MySqlCommand(query, connection);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    userId = Convert.ToInt32(result);
                }
            }
            return userId;
        }
        //public static string GetUserName(int userId)
        //{
        //    string userName = null;
        //    using (MySqlConnection connection = new MySqlConnection(connectionString))
        //    {
        //        connection.Open();
        //        string query = $"SELECT User_name FROM User WHERE user_id = {userId}";
        //        MySqlCommand command = new MySqlCommand(query, connection);
        //        object result = command.ExecuteScalar();
        //        if (result != null)
        //        {
        //            userName = result.ToString();
        //        }
        //    }
        //    return userName;
        //}
        public static int GetUserAge(int userId)
        {
            int age = -1;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT Age FROM User WHERE user_id = {userId}";
                MySqlCommand command = new MySqlCommand(query, connection);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    age = Convert.ToInt32(result);
                }
            }
            return age;
        }
        public static string GetUserGender(int userId)
        {
            string gender = null;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT Gender FROM User WHERE user_id = {userId}";
                MySqlCommand command = new MySqlCommand(query, connection);
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    gender = result.ToString();
                }
            }
            return gender;
        }
        public static string GetUserDateOfBirth(int userId)
        {
            string dateOfBirth = string.Empty;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT Date_of_birth FROM User WHERE user_id = {userId}";
                MySqlCommand command = new MySqlCommand(query, connection);
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    DateTime dateTime = Convert.ToDateTime(result);
                    dateOfBirth = dateTime.ToString("dd MMM yyyy");
                }
            }
            return dateOfBirth;
        }
        public static int GetUserHeight(int userId)
        {
            int height = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT Height FROM User WHERE user_id = {userId}";
                MySqlCommand command = new MySqlCommand(query, connection);
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    height = Convert.ToInt32(result);
                }
            }
            return height;
        }
        public static int GetUserWeight(int userId)
        {
            int weight = 0;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT Weight FROM User WHERE user_id = {userId}";
                MySqlCommand command = new MySqlCommand(query, connection);
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    weight = Convert.ToInt32(result);
                }
            }
            return weight;
        }
        public static string GetUserActivityLevel(int userId)
        {
            string activityLevel = string.Empty;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT Activity_level FROM User WHERE user_id = {userId}";
                MySqlCommand command = new MySqlCommand(query, connection);
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    activityLevel = result.ToString();
                }
            }
            return activityLevel;
        }
    }
}
