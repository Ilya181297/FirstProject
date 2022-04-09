using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HelloApp
{
    class Program
    {
       
        static async Task Main(string[] args)
        {
            string connectionString = "Server=DESKTOP-F3VVNA6\\;Database=Blogging;Trusted_Connection=true; TrustServerCertificate=True;";

            string sqlExpression = "SELECT * FROM blogger";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows) // если есть данные
                {
                    // выводим названия столбцов
                    string columnName1 = reader.GetName(0);
                    string columnName2 = reader.GetName(1);
                    string columnName3 = reader.GetName(2);

                    Console.WriteLine($"{columnName1}\t\t{columnName2}\t\t\t{columnName3}");

                    while (await reader.ReadAsync()) // построчно считываем данные
                    {
                        object ID = reader.GetValue(0);
                        object name = reader.GetValue(1);
                        object post = reader.GetValue(2);

                        Console.WriteLine($"{ID} \t\t{name} \t\t{post}");
                    }
                }

                await reader.CloseAsync();
            }
            

            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1 - Удалить");
            Console.WriteLine("2 - Добавить");
            Console.WriteLine("3 - Обновить");
            int number = System.Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:

                    Console.WriteLine("Вы выбрали удалить");
                    Console.WriteLine("Введите ID блогера:");
                    int id = Convert.ToInt32(Console.ReadLine());
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        await connection.OpenAsync();
                        string sql = string.Format("Delete from blogger where ID = '{0}'", id);
                        using (SqlCommand cmd = new SqlCommand(sql, connection))
                        {
                            try
                            {
                                cmd.ExecuteNonQuery();
                                Console.WriteLine("Запись удалена");
                            }
                            catch (SqlException ex)
                            {
                                Exception error = new Exception("Блогер не найден", ex);
                                throw error;
                            }
                        }
                        await connection.CloseAsync();
                    }
            
                    break;

                case 2:
                    Console.WriteLine("Вы выбрали добавить");
                    
                    using (SqlConnection connection = new SqlConnection(connectionString))

                    {
                        await connection.OpenAsync();

                        Console.WriteLine("Введите номер ID:");
                        int ID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите Имя:");
                        string? Name = Console.ReadLine();
                        Console.WriteLine("Введите пост:");
                        string? Post = Console.ReadLine();


                        string sql = string.Format("Insert Into blogger" +
                             "(ID, Name, Post) Values(@ID, @Name, @Post)");

                        using (SqlCommand cmd = new SqlCommand(sql, connection))
                        {
                            // Добавить параметры
                            cmd.Parameters.AddWithValue("@ID", ID);
                            cmd.Parameters.AddWithValue("@Name", Name);
                            cmd.Parameters.AddWithValue("@Post", Post);

                            cmd.ExecuteNonQuery();
                            
                        }
                        await connection.CloseAsync();
                    }
                    Console.WriteLine("Запись добавлена");
        
                    break;
                  


                case 3:
                    Console.WriteLine("Вы выбрали обновить");
                    break;
                    default:
                   
                    break;
                   
            }






        }





    }



}
