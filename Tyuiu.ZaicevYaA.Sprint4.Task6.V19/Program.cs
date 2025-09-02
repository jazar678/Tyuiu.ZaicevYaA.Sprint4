using System;
using Tyuiu.ZaicevYaA.Sprint4.Task6.V19.Lib;

class Program
{
    static void Main(string[] args)
    {
        Class1 service = new Class1();

        string[] browsers = { "Chrome", "Firefox", "Safari", "Opera", "Edge", "Internet Explorer", "Brave" };

        Console.WriteLine("Массив браузеров:");
        foreach (string browser in browsers)
        {
            Console.WriteLine(browser);
        }

        int result = service.Calculate(browsers);

        Console.WriteLine($"\nКоличество браузеров с названием длиннее 5 символов: {result}");

        // Дополнительно покажем, какие именно браузеры подходят под условие
        Console.WriteLine("\nБраузеры с названием длиннее 5 символов:");
        foreach (string browser in browsers)
        {
            if (browser.Length > 5)
            {
                Console.WriteLine($"{browser} (длина: {browser.Length})");
            }
        }

        Console.ReadKey();
    }
}