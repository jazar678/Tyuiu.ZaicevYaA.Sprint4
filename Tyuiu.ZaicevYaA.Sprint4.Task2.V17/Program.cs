using System;
using Tyuiu.ZaicevYaA.Sprint4.Task2.V17.Lib;

namespace Tyuiu.ZaicevYaA.Sprint4.Task2.V17.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса из библиотеки
            Class1 service = new Class1();

            // Создаем массив из 9 элементов
            int[] array = new int[9];

            // Заполняем массив случайными числами от 3 до 9
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(3, 10); // Next(3, 10) генерирует от 3 до 9 включительно
            }

            // Выводим массив на экран
            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            // Вызываем метод для подсчета произведения нечетных элементов
            int result = service.Calculate(array);

            // Выводим результат
            Console.WriteLine("Произведение нечетных элементов: " + result);

            // Дополнительно: покажем какие элементы нечетные
            Console.Write("Нечетные элементы: ");
            foreach (int element in array)
            {
                if (element % 2 != 0)
                {
                    Console.Write(element + " ");
                }
            }
            Console.WriteLine();

            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}