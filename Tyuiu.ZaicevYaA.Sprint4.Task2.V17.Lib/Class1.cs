using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZaicevYaA.Sprint4.Task2.V17.Lib
{
    public class Class1 : ISprint4Task2V17
    {
        public int Calculate(int[] array)
        {
            int result = 1;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (IsOdd(array[i]))
                {
                    result *= array[i];
                    count++;
                }
            }

            // Если нечетных элементов нет, возвращаем 1
            return count > 0 ? result : 1;
        }

        private bool IsOdd(int number)
        {
            return (number & 1) == 1; // Побитовая проверка на нечетность
        }
    }
}