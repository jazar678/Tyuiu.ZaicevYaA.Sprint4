using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZaicevYaA.Sprint4.Task3.V17.Lib
{
    public class Class1 : ISprint4Task3V17
    {
        public int Calculate(int[,] array)
        {
            int sum = 0;
            int rows = array.GetLength(0);

            // Четвертый столбец имеет индекс 3 (нумерация с 0)
            for (int i = 0; i < rows; i++)
            {
                sum += array[i, 3];
            }

            return sum;
        }
    }
}