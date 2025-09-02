using tyuiu.cources.programming.interfaces.Sprint4;
using System;

namespace Tyuiu.ZaicevYaA.Sprint4.Task5.V1.Lib
{
    public class Class1 : ISprint4Task5V1
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Создаем копию массива, чтобы не изменять исходный
            int[,] result = new int[rows, cols];

            // Копируем исходный массив
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j];
                }
            }

            // Заменяем положительные элементы на 1
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (result[i, j] > 0)
                    {
                        result[i, j] = 1;
                    }
                }
            }

            return result;
        }
    }
}