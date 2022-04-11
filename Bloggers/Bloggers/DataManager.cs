using Bloggers.Models;
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

        public void DeleteBloggers()
        {
            var number = Convert.ToInt32(Console.ReadLine());
            string sqlExpression = String.Format("Delete from blogger where ID = '{0}'", number);
            var connection = new SqlConnection(_connectionString);
            connection.Open();
            var command = new SqlCommand(sqlExpression, connection);
            try
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Запись удалена");
            }
            catch (SqlException ex)
            {
                var error = new Exception("Блогер не найден", ex);
                throw error;
            }
            connection.Close();
        }

        public void InsertBloggers()
        {
            Console.WriteLine("Введите ID:");
            var id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите Name:");
            var name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите Post:");
            var post = Convert.ToString(Console.ReadLine());

            string sqlExpression = string.Format("Insert Into blogger" +
                   "(ID, Name, Post) Values(@ID, @Name, @Post)");

            var connection = new SqlConnection(_connectionString);

            connection.Open();
            var command = new SqlCommand(sqlExpression, connection);
            command.Parameters.AddWithValue("@ID", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Post", post);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}


