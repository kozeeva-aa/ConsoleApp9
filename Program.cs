// ДЗ 1:
//Запросить у пользователя некоторое количество цифр на вход (от 3 до 7)
//все цифры сложить в массив по порядку
//обработать возможные ошибки через try - catch 
//по окончанию ввода от пользователя вывести на экран среднее арифметическое значение всех введённых чисел

using System;

namespace ConsoleApp8;

class ProgrammMass



{
    static void Main()
    {
               
        int[] numbers = new int[4];
        // Цикл для запроса 4 цифр у пользователя
        for (int i = 0; i < 4; i++)
        {
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine($"Введите цифру: ");
                try
                {
                    
                    int input = int.Parse(Console.ReadLine());

                    
                        numbers[i] = input;
                      isValid = true; 
                }
                catch (FormatException)
                {
                    
                    Console.WriteLine("Это не цифра!");
                }
                catch (Exception ex)
                {
                    
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                }
            }
        }

        // вывод массива
        Console.WriteLine("Массив: ");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }

        // сумма цифр массива
       int sum = 0;
       foreach (int num in numbers)
        {
            sum += num;
        }

        // среднее арифметическое
        double average = (double)sum / numbers.Length;
                      
        Console.WriteLine($"Среднее арифметическое: {average}");
    }
}



