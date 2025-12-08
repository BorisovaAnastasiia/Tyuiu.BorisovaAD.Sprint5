using Tyuiu.BorisovaAD.Sprint5.Task3.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнил: Борисова А.Д. | ИБПб-23-1"; // Замените на ваши ФИО и группу
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #26                                                             *");
        Console.WriteLine("* Выполнил: Борисова А.Д. | ИБПб-23-1                                     *"); // Замените на ваши ФИО и группу
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано выражение F(x) = 0.7x^3 + 1.52x^2. Вычислить значение              *");
        Console.WriteLine("* при x = 2, результат сохранить в бинарный файл OutPutFileTask3.bin      *");
        Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 2; // Ваше значение X
        Console.WriteLine($"x = {x}");

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        string path = ds.SaveToFileTextData(x);

        double result;
        using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
        {
            result = reader.ReadDouble();
        }

        Console.WriteLine($"Значение функции F(x) = {result}");
        Console.WriteLine($"Результат сохранён в файл: {path}");

        Console.ReadKey();
    }
}