using Tyuiu.BorisovaAD.Sprint5.Task2.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #5 | Выполнил: Борисова А. Д. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        // ... (остальной текст интерфейса без изменений) ...

        // Исходный массив из примера задания
        int[,] matrix = new int { { 6, 9, 4 }, { 7, 2, 4 }, { 4, 8, 3 } };

        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        Console.WriteLine($"Размерность массива: {rows}x{columns}");
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                // Изменен формат вывода: удален лишний пробел, 
                // чтобы соответствовать формату CSV без пробелов.
                Console.Write($"{matrix[i, j]}");
                if (j != columns - 1)
                {
                    Console.Write($";");
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string filePath = ds.SaveAndReplaceOdd(matrix);

        Console.WriteLine($"Файл создан: {filePath}");
        Console.WriteLine("Получившийся массив с заменой нечетных элементов на 0 (как в файле):");

        // Читаем файл и выводим его содержимое, чтобы показать точный результат
        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine(fileContent);

        Console.ReadKey();
    }
}