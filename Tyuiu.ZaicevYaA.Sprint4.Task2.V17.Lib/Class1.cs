using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.ZaicevYaA.Sprint4.Task2.V17.Lib
{
    public class Class1 : ISprint4Task2V17
    {
        public int Calculate(int[] array)
        {
            return CalculateProduct(array, 0);
        }

        private int CalculateProduct(int[] array, int index)
        {
            // Базовый случай - достигли конца массива
            if (index >= array.Length)
                return 1;

            int currentProduct = CalculateProduct(array, index + 1);

            // Если текущий элемент нечетный, умножаем на него
            if (array[index] % 2 != 0)
                return array[index] * currentProduct;
            else
                return currentProduct;
        }
    }
}