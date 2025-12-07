using Tyuiu.BorisovaAD.Sprint5.Task2.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        // Обновляем информацию под Вашу задачу и ФИО/группу
        Console.Title = "Спринт #5 | Выполнил: Борисова А. Д. | ИБКСб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Запись данных в текстовый файл                                    *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Борисова Александра Дмитриевна | ИБКСб-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
        Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.       *");
        Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        // Создаем и инициализируем двумерный массив 3х3 (вместо чтения с клавиатуры для примера)
        int[,] matrix = new int[,]
        {
            { 6, 9, 4 },
            { 7, 2, 4 },
            { 4, 8, 3 }
        };
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[i, j],3}");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        // Вызываем метод библиотеки для обработки массива и сохранения в файл
        string filePath = ds.SaveToFileTextData(matrix);

        Console.WriteLine("Обработанные данные сохранены в файл: " + filePath);
        Console.WriteLine("Содержимое файла OutPutFileTask2.csv:");
        // Считываем и выводим содержимое файла для наглядности
        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine(fileContent);

        Console.ReadKey();
    }
}