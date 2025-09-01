using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZaicevYaA.Sprint4.Task2.V17.Lib
{
    public class Class1 : ISprint4Task2V17
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasOdd = false;

            foreach (int element in array)
            {
                if (element % 2 != 0)
                {
                    product *= element;
                    hasOdd = true;
                }
            }

            // Если нечетных элементов нет, возвращаем 0
            // Или можно вернуть 1, в зависимости от требований
            return hasOdd ? product : 0;
        }
    }
}