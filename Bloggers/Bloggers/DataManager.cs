﻿using Bloggers.Models;
using Microsoft.Data.SqlClient;

namespace Bloggers
{
    internal class DataManager
    {
        private readonly string _connectionString;
        public DataManager()
        {
            _connectionString = "Server = DESKTOP-F3VVNA6\\; Database = Blogging; Trusted_Connection = true; TrustServerCertificate = True; ";
        }
        public List<Blogger> GetBloggers()
        {
            var bloggers = new List<Blogger>();
            string sqlExpression = "SELECT * FROM blogger";
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            var command = new SqlCommand(sqlExpression, connection);
            var reader = command.ExecuteReader();

            if (reader.HasRows) // если есть данные
            {
                while (reader.Read()) // построчно считываем данные
                {
                    object id = reader.GetValue(0);
                    object name = reader.GetValue(1);
                    object post = reader.GetValue(2);
                    var bloger = new Blogger
                    {
                        Id = Convert.ToInt32(id),
                        Name = Convert.ToString(name),
                        Post = Convert.ToString(post),
                    };
                    bloggers.Add(bloger);
                }
            }

            reader.Close();
            return bloggers;
        }

        public int DeleteBlogger(int numberBlogger)
        {

            string sqlExpression = String.Format("Delete from blogger where ID = '{0}'", numberBlogger);
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            var command = new SqlCommand(sqlExpression, connection);
            try
            {
                return command.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
            connection.Close();
        }

        public int InsertBlogger(int id, string? name, string? post)
        {
            string sqlExpression = string.Format("Insert Into blogger" +
                   "(ID, Name, Post) Values(@ID, @Name, @Post)");

            var connection = new SqlConnection(_connectionString);

            connection.Open();

            var command = new SqlCommand(sqlExpression, connection);

            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Post", post);
            try
            {
                return command.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
            connection.Close();
        }
    }
}


