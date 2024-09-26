// See https://aka.ms/new-console-template for more information//Console.WriteLine("Hello, World!");
//Сделать небольшой каталог пользователей (от 3 до 5)
//С консоли вводятся данные о пользователе (не менее двух вариантов)
//данные записываются в массив (либо двумерный, либо массив массивов, либо несколько разных массивов)
//По окончанию запросить у пользователя какого человека он хочет вывести

using System;

class Program
{
    // Класс для представления пользователя
    class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    static void Main()
    {
        // Массив для хранения 4 пользователей
        User[] users = new User[4];

        // Запрос данных для каждого пользователя
        for (int i = 0; i < users.Length; i++)
        {
            users[i] = new User(); // Создаем новый объект User

            Console.WriteLine($"Введите имя пользователя номер {i + 1}: ");
            users[i].Name = Console.ReadLine(); 

            bool isValidAge = false;
            while (!isValidAge)
            {
                Console.WriteLine($"Введите возраст пользователя номер {i + 1}: ");
                try
                {
                    users[i].Age = int.Parse(Console.ReadLine()); 
                    isValidAge = true; 
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка. Пожалуйста, введите число");
                }
            }
        }

        // Запрос номера пользователя для вывода информации
        bool isValidIndex = false;
        while (!isValidIndex)
        {
            Console.WriteLine("\nВведите номер пользователя для вывода (от 1 до 4): ");
            try
            {
                int userIndex = int.Parse(Console.ReadLine()) - 1; // Индексы начинаются с 0

                if (userIndex >= 0 && userIndex < users.Length)
                {
                    // Вывод данных о выбранном пользователе
                    Console.WriteLine($"\nПользователь #{userIndex + 1}:");
                    Console.WriteLine($"Имя: {users[userIndex].Name}");
                    Console.WriteLine($"Возраст: {users[userIndex].Age}");
                    isValidIndex = true; 
                }
                else
                {
                    Console.WriteLine("Ошибка");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка. Пожалуйста, введите число.");
            }
        }
    }
}

