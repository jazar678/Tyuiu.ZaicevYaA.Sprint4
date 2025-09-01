using System;
using Tyuiu.ZaicevYaA.Sprint4.Task2.V17.Lib;

class Program
{
    static void Main(string[] args)
    {
        Class1 service = new Class1();

        // Создаем массив из 9 элементов
        int[] array = new int[9];
        Random random = new Random();

        // Заполняем массив случайными числами от 3 до 9
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(3, 10); // Next(3, 10) генерирует от 3 до 9 включительно
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        // Вычисляем произведение нечетных элементов
        int result = service.Calculate(array);

        Console.WriteLine($"Произведение нечетных элементов: {result}");
        Console.ReadKey();
    }
}