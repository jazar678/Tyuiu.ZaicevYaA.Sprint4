using System;
using Tyuiu.ZaicevYaA.Sprint4.Task4.V14.Lib;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Class1 service = new Class1();

        // Создаем и заполняем массив
        int[,] matrix = new int[5, 5]
        {
            {1, 3, 7, 7, 6},
            {4, 2, 6, 3, 3},
            {4, 5, 1, 4, 6},
            {7, 5, 2, 7, 7},
            {2, 4, 4, 4, 7}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(matrix);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        // Вызываем метод для обработки массива
        int[,] result = service.Calculate(matrix);

        Console.WriteLine("Результат (нечетные элементы заменены на 0):");
        PrintArray(result);

        Console.ReadKey();
    }

    // Вспомогательный метод для вывода массива
    static void PrintArray(int[,] array)
    {
        int rows = array.GetUpperBound(0) + 1;
        int cols = array.GetUpperBound(1) + 1;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{array[i, j]} \t");
            }
            Console.WriteLine();
        }
    }
}