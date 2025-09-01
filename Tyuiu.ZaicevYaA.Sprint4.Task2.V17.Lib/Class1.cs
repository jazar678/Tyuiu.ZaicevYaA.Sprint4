using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZaicevYaA.Sprint4.Task2.V17.Lib
{
    public class Class1 : ISprint4Task2V17
    {
        public int Calculate(int[] array)
        {
            int product = 1;
            bool hasOdd = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    product *= array[i];
                    hasOdd = true;
                }
            }

            // Если не было нечетных элементов, возвращаем 0
            return hasOdd ? product : 0;
        }
    }
}