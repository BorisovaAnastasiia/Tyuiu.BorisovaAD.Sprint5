using Tyuiu.BorisovaAD.Sprint5.Task0.V12.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #5 | Выполнил: Никитин Р.Ю. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнил: Никитин Р.Ю. | ИБКСб-25-1                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить    *");
        Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.              *");
        Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");
        Console.WriteLine("* Формула: y = x³ / (2(x+5)²)                                             *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x = 3;
        Console.WriteLine($"x = {x}");

        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        DataService ds = new DataService();
        string path = ds.SaveToFileTextData(x);

        string result = File.ReadAllText(path);
        double y = double.Parse(result);

        Console.WriteLine($"Значение функции y = {y}");
        Console.WriteLine($"Результат сохранён в файл: {path}");

        Console.ReadKey();
    }
}