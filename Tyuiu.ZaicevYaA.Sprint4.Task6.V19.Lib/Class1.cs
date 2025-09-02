using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ZaicevYaA.Sprint4.Task6.V19.Lib
{
    public class Class1 : ISprint4Task6V19
    {
        public int Calculate(string[] array)
        {
            int count = 0;
            foreach (string element in array)
            {
                if (element.Length > 5)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
