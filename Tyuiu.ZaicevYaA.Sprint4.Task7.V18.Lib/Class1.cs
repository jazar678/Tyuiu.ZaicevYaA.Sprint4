using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZaicevYaA.Sprint4.Task7.V18.Lib
{
    public class Class1 : ISprint4Task7V18
    {
        public int Calculate(int n, int m, string value)
        {
            // Преобразуем строку в матрицу n x m
            int[,] matrix = new int[n, m];
            int index = 0;

            // Заполняем матрицу значениями из строки
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (index < value.Length)
                    {
                        matrix[i, j] = int.Parse(value[index].ToString());
                        index++;
                    }
                }
            }

            // Подсчитываем произведение четных чисел
            int product = 1;
            bool hasEven = false;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        product *= matrix[i, j];
                        hasEven = true;
                    }
                }
            }

            // Если четных чисел нет, возвращаем 0
            return hasEven ? product : 0;
        }
    }
}