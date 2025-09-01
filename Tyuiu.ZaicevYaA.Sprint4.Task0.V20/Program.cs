using System;
using Tyuiu.ZaicevYaA.Sprint4.Task0.V20.Lib;

namespace Tyuiu.ZaicevYaA.Sprint4.Task0.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 service = new Class1();

            // Исходный массив
            int[] array = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };

            // Выводим массив
            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            // Вычисляем произведение четных элементов
            int result = service.GetMultEvenArrEl(array);

            // Выводим результат
            Console.WriteLine("Произведение четных элементов: " + result);

            // Показываем, какие элементы являются четными
            Console.Write("Четные элементы: ");
            foreach (int item in array)
            {
                if (item % 2 == 0)
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}