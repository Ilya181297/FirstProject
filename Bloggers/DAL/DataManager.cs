using Bloggers.Models;
using Microsoft.Data.SqlClient;

namespace Bloggers
{
    public class DataManager
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

        public bool DeleteBlogger(int idForDelete)
        {
            string sqlExpression = String.Format("Delete from blogger where ID = '{0}'", idForDelete);
            var connection = new SqlConnection(_connectionString);
            try
            {
                connection.Open();
                var command = new SqlCommand(sqlExpression, connection);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Возникло исключение: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
        public bool UpdateBlogger(int idForUpgate, string? nameForUpdate, string? postForUpdate)
        {
            string sqlExpression = $"Update blogger Set Name = '{nameForUpdate}', Post = '{postForUpdate}'" +
                $" Where ID = '{idForUpgate}'";
            var connection = new SqlConnection(_connectionString);
            try
            {
                connection.Open();
                var command = new SqlCommand(sqlExpression, connection);
                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Возникло исключение: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool InsertBlogger(int id, string? name, string? post)
        {

            string sqlExpression = string.Format("Insert Into blogger" +
                   "(ID, Name, Post) Values(@ID, @Name, @Post)");

            var connection = new SqlConnection(_connectionString);
            try
            {
                connection.Open();

                var command = new SqlCommand(sqlExpression, connection);

                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Post", post);

                return command.ExecuteNonQuery() > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Возникло исключение: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}


