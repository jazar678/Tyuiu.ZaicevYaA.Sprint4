using Tyuiu.ZaicevYaA.Sprint4.Task0.V20.Lib;

Console.Title = "Спринт | Выполнил: Зайцев Я.А. | ПКТб-24-1";
Console.WriteLine("*****************************************************************");
Console.WriteLine("* Спринт #4                                                     *");
Console.WriteLine("* Тема: Одномерные массивы                                      *");
Console.WriteLine("* Задание #0                                                    *");
Console.WriteLine("* Вариант #20                                                   *");
Console.WriteLine("* Выполнил: Зайцев Ярослав Александрович | ПКТб-24-1            *");
Console.WriteLine("*****************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                      *");
Console.WriteLine("* Подсчитать произведение четных элементов одномерного массива.*");
Console.WriteLine("*                                                               *");
Console.WriteLine("*****************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                              *");
Console.WriteLine("*****************************************************************");

int[] array = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };

Console.WriteLine("Массив: { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 }");
Console.WriteLine("*****************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
Console.WriteLine("*****************************************************************");

Class1 task = new Class1();
int result = task.GetMultEvenArrEl(array);

Console.WriteLine($"Произведение четных элементов = {result}");
Console.ReadKey();