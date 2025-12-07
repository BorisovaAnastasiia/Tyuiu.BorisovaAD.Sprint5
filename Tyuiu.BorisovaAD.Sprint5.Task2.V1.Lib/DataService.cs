using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.BorisovaAD.Sprint5.Task2.V1.Lib
{
    public class DataService : ISprint5Task2V1
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            // Формируем путь к файлу в директории Temp с помощью Path.GetTempPath() и Path.Combine()
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            // Создаем строку для записи в файл, заменяя нечетные элементы на 0
            string strMatrix = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    // Проверяем на нечетность и заменяем
                    if (matrix[i, j] % 2 != 0)
                    {
                        matrix[i, j] = 0;
                    }

                    // Форматируем строку для CSV: точка с запятой между элементами
                    strMatrix += matrix[i, j];

                    // Вот тут было: strMatrix += matrix[i, j] + "; "
                    // Мы изменили на: strMatrix += matrix[i, j] + ";"
                    if (j != columns - 1)
                    {
                        strMatrix += ";";
                    }
                }
                // Переход на новую строку после ряда
                if (i != rows - 1)
                {
                    strMatrix += Environment.NewLine;
                }
            }

            // Записываем сформированную строку в файл
            File.WriteAllText(path, strMatrix);

            // Возвращаем полный путь к файлу
            return path;
        }
    }
}
