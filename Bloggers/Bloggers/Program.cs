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

        static async void Main(string[] args)
        {
       
            bool status = true;

            while (status)
            {
                Zaprosi.Vivod();
                
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
                        Zaprosi.Delete();
                        break;

                    case 2:
                        Console.WriteLine("Вы выбрали добавить");
                        Console.WriteLine("Запись добавлена");
                        Zaprosi.Insert();
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

