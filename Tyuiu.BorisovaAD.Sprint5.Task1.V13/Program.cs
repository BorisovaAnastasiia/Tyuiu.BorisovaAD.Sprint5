using Tyuiu.BorisovaAD.Sprint5.Task1.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       ");
        Console.WriteLine("***************************************************************************");
        int start = -5;
        Console.WriteLine("страрт диапозон функции:" + start);
        int end = 5;
        Console.WriteLine("конец диапозон функции:" + end);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Результат:                                                             ");
        Console.WriteLine("***************************************************************************");
        string result = ds.SaveToFileTextData(-5, 5);
        Console.WriteLine("Файл: " + result);

        double funcValue = 0;
        for (int i = start; i < end + 1; i++)
        {
            funcValue = ((2 * i - 3) / (Math.Cos(i) + i)) + 5;
            if (double.IsInfinity(funcValue))
            {
                funcValue = 0;
            }
            funcValue = Math.Round(funcValue, 2);
            string yValue = funcValue.ToString();
            Console.WriteLine($"  f({i,2}) = {funcValue}");
        }
        Console.ReadKey();
    }
}