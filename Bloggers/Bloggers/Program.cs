using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Bloggers;


namespace HelloApp
{
    class Program
    {

        static void Main(string[] args)
        {
            var dataManager = new DataManager();

            bool status = true;

            while (status)
            {
                var bloggers = dataManager.GetBloggers();
                foreach(var blogger in bloggers)
                {
                    Console.WriteLine($"{blogger.Id}\t{blogger.Name}\t{blogger.Post}");
                }
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1 - Удалить");
                Console.WriteLine("2 - Добавить");
                Console.WriteLine("3 - Закончить работу");
                int number = System.Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Вы выбрали удалить");
                        Console.WriteLine("Введите ID блогера:");
                        dataManager.DeleteBloggers();
                        break;

                    case 2:
                        Console.WriteLine("Вы выбрали добавить");
                        dataManager.InsertBloggers();
                        Console.WriteLine("Запись добавлена");
                        break;

                    case 3:
                        Console.WriteLine("Работа закончена");
                        status = false;
                        break;

                }
            }
        }
    }
}

