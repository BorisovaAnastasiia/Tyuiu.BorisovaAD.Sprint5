using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BorisovaAD.Sprint5.Task4.V22.Lib
{
    public class DataService : ISprint5Task4V22
    {
        public double LoadFromDataFile(string path)
        {
            // Чтение значения из файла
            string fileContent = File.ReadAllText(path);

            // Преобразование строки в double с учетом разделителя (точки или запятой)
            double x;
            if (!double.TryParse(fileContent, NumberStyles.Any, CultureInfo.InvariantCulture, out x))
            {
                throw new ArgumentException($"Не удалось преобразовать значение '{fileContent}' в число.");
            }

            // Вычисление формулы: y = x^3 * sin(x) - 4x
            double result = Math.Pow(x, 3) * Math.Sin(x) - 4 * x;

            // Округление до трех знаков после запятой
            return Math.Round(result, 3);
        }
    }
}
