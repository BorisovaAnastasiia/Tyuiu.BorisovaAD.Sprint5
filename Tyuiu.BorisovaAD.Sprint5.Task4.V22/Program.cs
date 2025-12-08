using Tyuiu.BorisovaAD.Sprint5.Task4.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнила: Борисова А. Д. | ИСТНб-23-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #22                                                             *");
        Console.WriteLine("* Выполнила: Борисова Анастасия Дмитриевна | ИСТНб-23-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл с вещественным значением. Прочитать значение из файла и        *");
        Console.WriteLine("* подставить вместо X в формуле y = x^3 * sin(x) - 4x.                    *");
        Console.WriteLine("* Вычислить значение по формуле и вернуть полученный результат на консоль.*");
        Console.WriteLine("* Полученное значение округлить до трёх знаков после запятой.             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        // Создание пути к файлу
        string path = @"C:\DataSprint5\InPutDataFileTask4V22.txt";

        // Проверка существования файла
        if (!File.Exists(path))
        {
            // Альтернативный вариант: создание временного файла с тестовым значением
            Console.WriteLine("Файл не найден. Используется тестовый файл во временной папке.");

            // Создание временного файла с помощью Path.GetTempFileName()
            path = Path.GetTempFileName();

            // Запись тестового значения в файл (например, 2.5)
            File.WriteAllText(path, "2.5");
            Console.WriteLine($"Создан временный файл: {path}");
            Console.WriteLine($"Содержимое: 2.5");
        }
        else
        {
            Console.WriteLine($"Файл найден: {path}");
            string fileContent = File.ReadAllText(path);
            Console.WriteLine($"Содержимое файла: {fileContent}");
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        try
        {
            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);
            Console.WriteLine($"Значение выражения = {result}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }

        Console.ReadKey();
    }
}