using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZaicevYaA.Sprint4.Task4.V14.Lib
{
    public class Class1 : ISprint4Task4V14
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.GetUpperBound(1) + 1;

            // Создаем копию массива для возврата результата
            int[,] result = new int[rows, cols];

            // Копируем исходный массив
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j];
                }
            }

            // Заменяем нечетные элементы на 0
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (result[i, j] % 2 != 0)
                    {
                        result[i, j] = 0;
                    }
                }
            }

            return result;
        }
    }
}