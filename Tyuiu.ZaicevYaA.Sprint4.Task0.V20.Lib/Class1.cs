using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZaicevYaA.Sprint4.Task0.V20.Lib
{
    public class Class1 : ISprint4Task0V20
    {
        public int GetMultEvenArrEl(int[] array)
        {
            int product = 1;
            bool hasEven = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    product *= array[i];
                    hasEven = true;
                }
            }

            // Если нет четных элементов, возвращаем 0
            if (!hasEven)
            {
                return 0;
            }

            return product;
        }
    }
}