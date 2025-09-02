using System;
using Tyuiu.ZaicevYaA.Sprint4.Task5.V1.Lib;

class Program
{
    static void Main(string[] args)
    {
        // Создаем экземпляр класса из библиотеки
        Class1 service = new Class1();

        // Создаем двумерный массив 5x5
        int[,] matrix = new int[5, 5];

        // Заполняем массив случайными значениями от -9 до 8
        Random random = new Random();
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matrix[i, j] = random.Next(-9, 9); // Next(min, max) - max не включается
                Console.Write(matrix[i, j].ToString().PadLeft(4));
            }
            Console.WriteLine();
        }

        // Вызываем метод из библиотеки для обработки массива
        int[,] result = service.Calculate(matrix);

        // Выводим результат
        Console.WriteLine("\nМассив после замены положительных элементов на 1:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(result[i, j].ToString().PadLeft(4));
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}