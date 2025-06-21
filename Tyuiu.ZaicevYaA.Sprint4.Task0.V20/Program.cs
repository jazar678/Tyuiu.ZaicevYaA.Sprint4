using System;
using Tyuiu.ZaicevYaA.Sprint4.Task0.V20.Lib;

namespace Tyuiu.ZaicevYaA.Sprint4.Task0.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[] array = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };

            int result = ds.GetMultEvenArrEl(array);

            Console.Title = "Спринт | Выполнил: Зайцев Я.А. | ПКТб-24-1";
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Спринт #4                                                     *");
            Console.WriteLine("* Тема: Одномерные массивы                                      *");
            Console.WriteLine("* Задание #0                                                    *");
            Console.WriteLine("* Вариант #20                                                   *");
            Console.WriteLine("* Выполнил : Зайцев Ярослав Александрович | ПКТб-24-1           *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* УСЛОВИЕ :                                                     *");
            Console.WriteLine("* Подсчитать произведение четных элементов массива             *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*                                                               *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*****************************************************************");
            Console.Write("Массив = { ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1) Console.Write(", ");
            }
            Console.WriteLine(" }");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("Произведение четных элементов:");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}