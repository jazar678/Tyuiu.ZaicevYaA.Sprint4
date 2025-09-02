using System;
using Tyuiu.ZaicevYaA.Sprint4.Task3.V17.Lib;

class Program
{
    static void Main(string[] args)
    {
        Class1 service = new Class1();

        // Создаем массив с заданными значениями
        int[,] array = {
            {6, 4, 2, 2, 1},
            {3, 6, 5, 4, 1},
            {5, 2, 3, 1, 6},
            {8, 8, 4, 5, 3},
            {7, 4, 5, 1, 6}
        };

        // Выводим массив для наглядности
        Console.WriteLine("Массив 5x5:");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }

        // Вычисляем сумму элементов в четвертом столбце
        int result = service.Calculate(array);

        Console.WriteLine();
        Console.WriteLine("Четвертый столбец (индекс 3):");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"array[{i}, 3] = {array[i, 3]}");
        }

        Console.WriteLine();
        Console.WriteLine("Сумма элементов в четвертом столбце: " + result);

        Console.ReadKey();
    }
}