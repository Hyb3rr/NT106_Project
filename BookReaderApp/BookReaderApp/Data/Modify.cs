using BookReaderApp.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookReaderApp.Data
{
    class Modify
    {
        public List<Account> Accounts(string query) // Lay du lieu tu database
        {
            List<Account> accounts = new List<Account>();
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                SqlCommand sqlcommand = new SqlCommand(query, connection);
                SqlDataReader reader = sqlcommand.ExecuteReader();
                //reader.GetString(1), reader.GetString(2)
                while (reader.Read())
                {
                    accounts.Add(new Account(reader.GetString(1), reader.GetString(2)));
                }
                connection.Close();
            }
            return accounts;
        }

        internal void ModifyData(string query)
        {
            throw new NotImplementedException();
        }
        public void Command(string query) // Thuc thi cau lenh
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void UpdatePassword(string email, string newPassword)
        {
            string hashedPassword = PasswordHelper.HashPassword(newPassword);
            string query = "UPDATE Users SET PasswordHash = @hashedPassword WHERE Email = @Email";

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@hashedPassword", hashedPassword);
                command.Parameters.AddWithValue("@Email", email);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
