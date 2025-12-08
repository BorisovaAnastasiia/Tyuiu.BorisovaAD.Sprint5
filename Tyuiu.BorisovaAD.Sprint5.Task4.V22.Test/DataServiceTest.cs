using Tyuiu.BorisovaAD.Sprint5.Task4.V22.Lib;
namespace Tyuiu.BorisovaAD.Sprint5.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            // Создаем временный файл с тестовым значением
            string path = @"C:\Users\User\source\repos\Tyuiu.BorisovaAD.Sprint5\Task4\TestFile.txt";

            // Создаем директорию, если она не существует
            string dir = Path.GetDirectoryName(path);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // Записываем тестовое значение
            File.WriteAllText(path, "2.5");

            // Создаем экземпляр сервиса и вызываем метод
            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            // Ожидаемый результат для x = 2.5
            // y = x^3 * sin(x) - 4x
            // x^3 = 15.625
            // sin(2.5) ≈ 0.5985
            // x^3 * sin(x) ≈ 15.625 * 0.5985 ≈ 9.353
            // 4x = 10
            // 9.353 - 10 = -0.647
            // Округление до 3 знаков: -0.647
            double expected = -0.647;

            // Проверяем результат с учетом округления
            Assert.AreEqual(expected, result);

            // Удаляем временный файл
            File.Delete(path);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidDataInFile()
        {
            // Создаем временный файл с неверными данными
            string path = @"C:\Users\User\source\repos\Tyuiu.BorisovaAD.Sprint5\Task4\InvalidFile.txt";

            // Создаем директорию, если она не существует
            string dir = Path.GetDirectoryName(path);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // Записываем нечисловое значение
            File.WriteAllText(path, "не число");

            // Создаем экземпляр сервиса и вызываем метод
            // Должно выбросить ArgumentException
            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            // Удаляем временный файл
            File.Delete(path);
        }

        [TestMethod]
        public void TestWithZero()
        {
            // Создаем временный файл с нулевым значением
            string path = @"C:\Users\User\source\repos\Tyuiu.BorisovaAD.Sprint5\Task4\ZeroFile.txt";

            // Создаем директорию, если она не существует
            string dir = Path.GetDirectoryName(path);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // Записываем нулевое значение
            File.WriteAllText(path, "0");

            // Создаем экземпляр сервиса и вызываем метод
            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            // y = x^3 * sin(x) - 4x
            // При x = 0: 0 * sin(0) - 0 = 0
            double expected = 0;

            // Проверяем результат
            Assert.AreEqual(expected, result);

            // Удаляем временный файл
            File.Delete(path);
        }

        [TestMethod]
        public void TestWithNegativeNumber()
        {
            // Создаем временный файл с отрицательным значением
            string path = @"C:\Users\User\source\repos\Tyuiu.BorisovaAD.Sprint5\Task4\NegativeFile.txt";

            // Создаем директорию, если она не существует
            string dir = Path.GetDirectoryName(path);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // Записываем отрицательное значение
            File.WriteAllText(path, "-1.5");

            // Создаем экземпляр сервиса и вызываем метод
            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);
            
            // y = x^3 * sin(x) - 4x

// При x = -1.5:
            // x^3 = -3.375
            // sin(-1.5) ≈ -0.9975
            // x^3 * sin(x) ≈ -3.375 * -0.9975 ≈ 3.367
            // 4x = -6
            // 3.367 - (-6) = 9.367
            // Округление до 3 знаков: 9.367
            double expected = 9.367;

            // Проверяем результат с учетом округления
            Assert.AreEqual(expected, result);

            // Удаляем временный файл
            File.Delete(path);
        }

        [TestMethod]
        public void TestWithLargeNumber()
        {
            // Создаем временный файл с большим значением
            string path = @"C:\Users\User\source\repos\Tyuiu.BorisovaAD.Sprint5\Task4\LargeFile.txt";

            // Создаем директорию, если она не существует
            string dir = Path.GetDirectoryName(path);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // Записываем большое значение
            File.WriteAllText(path, "10");

            // Создаем экземпляр сервиса и вызываем метод
            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            // y = x^3 * sin(x) - 4x
            // При x = 10:
            // x^3 = 1000
            // sin(10) ≈ -0.5440
            // x^3 * sin(x) ≈ 1000 * -0.5440 ≈ -544.0
            // 4x = 40
            // -544.0 - 40 = -584.0
            // Округление до 3 знаков: -584.0
            double expected = -584.0;

            // Проверяем результат с учетом округления
            Assert.AreEqual(expected, result);

            // Удаляем временный файл
            File.Delete(path);
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void FileNotFoundTest()
        {
            // Пытаемся прочитать несуществующий файл
            string path = @"C:\Users\User\source\repos\Tyuiu.BorisovaAD.Sprint5\Task4\NonExistentFile.txt";

            // Создаем экземпляр сервиса и вызываем метод
            // Должно выбросить FileNotFoundException
            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);
        }

        [TestMethod]
        public void TestWithCommaDecimalSeparator()
        {
            // Создаем временный файл с числом с запятой (европейский формат)
            string path = @"C:\Users\User\source\repos\Tyuiu.BorisovaAD.Sprint5\Task4\CommaFile.txt";

            // Создаем директорию, если она не существует
            string dir = Path.GetDirectoryName(path);
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            // Записываем значение с запятой как разделитель
            File.WriteAllText(path, "3,5");

            // Создаем экземпляр сервиса и вызываем метод
            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            // y = x^3 * sin(x) - 4x
            // При x = 3.5:
            // x^3 = 42.875
            // sin(3.5) ≈ -0.3508
            // x^3 * sin(x) ≈ 42.875 * -0.3508 ≈ -15.04
            // 4x = 14
            // -15.04 - 14 = -29.04
            // Округление до 3 знаков: -29.04
            double expected = -29.04;

            // Проверяем результат с учетом округления
            Assert.AreEqual(expected, result);

            // Удаляем временный файл
            File.Delete(path);
        }

        [TestMethod]
        public void TestWithMultipleLines()
        {
            // Создаем временный файл с несколькими строками
            string path = @"C:\Users\User\source\repos\Tyuiu.BorisovaAD.Sprint5\Task4\MultiLineFile.txt";

            // Создаем директорию, если она не существует
            string dir = Path.GetDirectoryName(path);
            if (!Directory.Exists(dir)) ;

{
                Directory.CreateDirectory(dir);
            }

            // Записываем несколько строк, но метод должен прочитать только первую
            File.WriteAllText(path, "1.5\n2.5\n3.5");

            // Создаем экземпляр сервиса и вызываем метод
            DataService ds = new DataService();
            double result = ds.LoadFromDataFile(path);

            // y = x^3 * sin(x) - 4x
            // При x = 1.5:
            // x^3 = 3.375
            // sin(1.5) ≈ 0.9975
            // x^3 * sin(x) ≈ 3.375 * 0.9975 ≈ 3.366
            // 4x = 6
            // 3.366 - 6 = -2.634
            // Округление до 3 знаков: -2.634
            double expected = -2.634;

            // Проверяем результат с учетом округления
            Assert.AreEqual(expected, result);

            // Удаляем временный файл
            File.Delete(path);
        }
    }
}
