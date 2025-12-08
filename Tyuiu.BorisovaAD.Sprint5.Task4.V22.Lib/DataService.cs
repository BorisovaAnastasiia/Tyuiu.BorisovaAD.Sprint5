using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BorisovaAD.Sprint5.Task4.V22.Lib
{
    public class DataService : ISprint5Task4V22
    {
        public double LoadFromDataFile(string path)
        {
            string fileData = File.ReadAllText(path);
            double x = Convert.ToDouble(fileData);

            // Применяем формулу из изображения: y = x^3 * sin(x) - 4x
            double result = Math.Pow(x, 3) * Math.Sin(x) - 4 * x;

            return result;
        }
    }
}
