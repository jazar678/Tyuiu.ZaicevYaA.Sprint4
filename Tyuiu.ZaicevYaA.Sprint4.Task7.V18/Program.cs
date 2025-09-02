using System;
using Tyuiu.ZaicevYaA.Sprint4.Task7.V18.Lib;

class Program
{
    static void Main(string[] args)
    {
        Class1 service = new Class1();

        // Исходные данные
        string inputString = "145258749635789";
        int rows = 5;
        int columns = 3;

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"Строка: {inputString}");
        Console.WriteLine($"Размер матрицы: {rows} x {columns}");

        // Преобразуем строку в матрицу для отображения
        int[,] matrix = new int[rows, columns];
        int index = 0;

        Console.WriteLine("\nМатрица:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                if (index < inputString.Length)
                {
                    matrix[i, j] = int.Parse(inputString[index].ToString());
                    Console.Write(matrix[i, j] + " ");
                    index++;
                }
            }
            Console.WriteLine();
        }

        // Вызываем метод из библиотеки
        int result = service.Calculate(rows, columns, inputString);

        Console.WriteLine("\n***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine($"Произведение четных чисел: {result}");

        Console.ReadKey();
    }
}