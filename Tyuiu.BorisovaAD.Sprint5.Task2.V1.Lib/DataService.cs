using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BorisovaAD.Sprint5.Task2.V1.Lib
{
    public class DataService : ISprint5Task2V1
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            // Используем Path.GetTempPath() для получения пути к временной директории и Path.Combine() для создания полного пути к файлу.
            string fileName = "OutPutFileTask2.csv";
            string tempPath = Path.GetTempPath();
            string filePath = Path.Combine(tempPath, fileName);

            // Логика обработки массива и формирования CSV строки
            StringBuilder sb = new StringBuilder();
            int rows = matrix.GetLength(0); // Количество строк
            int cols = matrix.GetLength(1); // Количество столбцов

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int value = matrix[i, j];
                    // Заменяем нечетные элементы массива на 0
                    if (value % 2 != 0)
                    {
                        value = 0;
                    }
                    sb.Append(value);
                    // Добавляем разделитель (точку с запятой и пробел) между элементами строки, кроме последнего
                    if (j < cols - 1)
                    {
                        sb.Append("; ");
                    }
                }
                // Добавляем перевод строки, кроме последней строки файла
                if (i < rows - 1)
                {
                    sb.AppendLine();
                }
            }

            // Сохраняем сформированную строку в файл, используя File.WriteAllText
            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);

            return filePath;
        }
    }
}
