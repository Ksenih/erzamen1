using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Программа сложения двух чисел.");

        while (true)
        {
            try
            {
                int num1 = GetInteger("Введите первое число: ");
                int num2 = GetInteger("Введите второе число: ");

                Console.WriteLine($"Сумма чисел: {num1 + num2}");
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }

    static int GetInteger(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            try
            {
                return int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод! Пожалуйста, введите целое число.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Введенное число слишком велико или слишком мало.");
            }
        }
    }
}