using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BorisovaAD.Sprint5.Task1.V13.Lib
{
    public class DataService : ISprint5Task1V13
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            double funcValue = 0;
            for (int i = startValue; i < stopValue + 1; i++)
            {
                funcValue = ((2 * i - 3) / (Math.Cos(i) + i)) + 5;
                if (double.IsInfinity(funcValue))
                {
                    funcValue = 0;
                }
                funcValue = Math.Round(funcValue, 2);

                string result = funcValue.ToString();
                File.AppendAllText(path, $"{result}\n");
            }
            return path;
        }
    }
}
