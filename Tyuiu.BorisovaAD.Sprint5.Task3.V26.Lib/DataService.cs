using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BorisovaAD.Sprint5.Task3.V26.Lib
{
    public class DataService : ISprint5Task3V26
    {
        public string SaveToFileTextData(int x)
        {
            // Используем Path.GetTempPath() для получения временной директории
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            // Вычисление значения выражения F(x) = 0.7x^3 + 1.52x^2
            // при x = 2
            double result = 0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2);

            // Округление до трех знаков после запятой
            result = Math.Round(result, 3);

            // Запись результата в бинарный файл
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create)))
            {
                writer.Write(result);
            }

            return path;
        }
    }
}
