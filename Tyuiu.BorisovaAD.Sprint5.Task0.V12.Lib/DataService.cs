using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BorisovaAD.Sprint5.Task0.V12.Lib
{
    public class DataService : ISprint5Task0V12
    {
        public string SaveToFileTextData(int x)
        {
            double y = Math.Pow(x, 3) / (2 * Math.Pow(x + 5, 2));
            y = Math.Round(y, 3);

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");

            File.WriteAllText(path, y.ToString());

            return path;
        }
    }
}
