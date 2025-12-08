using Tyuiu.BorisovaAD.Sprint5.Task4.V22.Lib;
namespace Tyuiu.BorisovaAD.Sprint5.Task4.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string fileName = "InPutDataFileTask4V22.txt";
            string path = Path.Combine(Path.GetTempPath(), fileName);

            // Подготовка: Создаем файл с известным значением для теста (например, 1.0)
            double inputValue = 1.0;
            File.WriteAllText(path, inputValue.ToString());

            // Ожидаемый результат: Рассчитываем вручную по формуле и округляем
            // Формула: y = x^3 * sin(x) - 4x
            double wait = Math.Pow(inputValue, 3) * Math.Sin(inputValue) - 4 * inputValue;
            wait = Math.Round(wait, 3);

            // Действие: Вызываем тестируемый метод
            double res = ds.LoadFromDataFile(path);
            // Округляем полученный результат для точного сравнения с wait
            res = Math.Round(res, 3);

            // Проверка: Сравниваем ожидаемый и фактический результаты
            Assert.AreEqual(wait, res);

            // Очистка: Удаляем временный файл после теста (опционально)
            if (File.Exists(path))
            {
                File.Delete(path);
            }
    }
}
