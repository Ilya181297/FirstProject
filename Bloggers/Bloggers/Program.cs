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
                foreach (var blogger in bloggers)
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
                        int numberBlogger = Convert.ToInt32(Console.ReadLine());
                        var result = dataManager.DeleteBlogger(numberBlogger);
                        if (result == 0)
                        {
                            Console.WriteLine("Блогера с таким ID не существует");
                        }
                        else 
                        {
                            Console.WriteLine("Блогер удален");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Вы выбрали добавить");
                        Console.WriteLine("Введите ID:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите Name:");
                        string? name = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Введите Post:");
                        string? post = Convert.ToString(Console.ReadLine());
                        result = dataManager.InsertBlogger(id, name, post);
                        if (result == 0)
                        {
                            Console.WriteLine("Введены не корректные данные. Блогер не добавлен");
                        }
                        else
                        {
                            Console.WriteLine("Блогер добавлен");
                        }
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

