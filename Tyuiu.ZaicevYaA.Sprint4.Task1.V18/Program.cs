using System;
using Tyuiu.ZaicevYaA.Sprint4.Task1.V18.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        // Входные данные
        int[] array = { 7, 6, 9, 8, 9, 7, 4, 7, 8, 5, 6, 3, 9, 7, 9, 7 };

        // Вывод исходного массива
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        // Вычисление суммы нечетных элементов
        int result = ds.Calculate(array);

        // Вывод результата
        Console.WriteLine("Сумма нечетных элементов = " + result);

        Console.ReadKey();
    }
}