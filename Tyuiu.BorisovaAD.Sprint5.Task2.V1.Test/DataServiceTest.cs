using Tyuiu.BorisovaAD.Sprint5.Task2.V1.Lib;
namespace Tyuiu.BorisovaAD.Sprint5.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            // Тестовый массив
            int[,] matrix = new int[,]
            {
                { 6, 9, 4 },
                { 7, 2, 4 },
                { 4, 8, 3 }
            };

            // Ожидаемый результат в файле (с учетом замен нечетных на 0 и формата "; ")
            string expectedContent = "6; 0; 4\r\n7; 0; 4\r\n4; 8; 0";

            // Вызываем метод и получаем путь к созданному файлу
            string path = ds.SaveToFileTextData(matrix);

            // Проверяем, что файл действительно существует
            Assert.IsTrue(File.Exists(path));

            // Считываем содержимое файла и сравниваем с ожидаемым результатом
            string actualContent = File.ReadAllText(path);
            Assert.AreEqual(expectedContent, actualContent);

            // Опционально: можно удалить временный файл после теста
            File.Delete(path);
        }
    }
}
