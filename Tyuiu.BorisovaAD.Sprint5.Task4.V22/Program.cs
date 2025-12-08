using Tyuiu.BorisovaAD.Sprint5.Task4.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Борисова А.Д. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнил: Борисова А.Д. | ИБКСб-25-1                                    *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл, в котором есть вещественное значение. Прочитать значение      *");
        Console.WriteLine("* из файла и подставить вместо Х в формуле:                               *");
        Console.WriteLine("* y = x^3 * sin(x) - 4x                                                   *");
        Console.WriteLine("* Вычислить значение и вернуть полученный результат на консоль.           *");
        Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string fileName = "InPutDataFileTask4V22.txt";
        string path = Path.Combine(Path.GetTempPath(), fileName);

        // Записываем тестовое значение в файл (например, 1.0) для демонстрации работы
        File.WriteAllText(path, "1.0");

        Console.WriteLine($"Данные находятся в файле: {path}");

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double result = ds.LoadFromDataFile(path);

        // Форматируем результат до 3 знаков после запятой при выводе
        Console.WriteLine($"Значение функции y = {result:F3}");

        Console.ReadKey();
    }
}