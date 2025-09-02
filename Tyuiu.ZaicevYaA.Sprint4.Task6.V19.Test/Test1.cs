using System;
using Tyuiu.ZaicevYaA.Sprint4.Task6.V19.Lib;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine();

        Class1 service = new Class1();

        string[] browsers = { "Chrome", "Firefox", "Safari", "Opera", "Edge", "Internet Explorer", "Brave" };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < browsers.Length; i++)
        {
            Console.WriteLine($"Элемент {i}: {browsers[i]}");
        }

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int result = service.Calculate(browsers);

        Console.WriteLine($"Количество элементов с длиной больше 5: {result}");

        Console.ReadKey();
    }
}