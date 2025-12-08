using Tyuiu.BorisovaAD.Sprint5.Task3.V26.Lib;
namespace Tyuiu.BorisovaAD.Sprint5.Task3.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            int x = 2; // Ваше значение X

            // Расчет ожидаемого результата вручную (или программно для теста)
            double wait = 0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2);
            wait = Math.Round(wait, 3); // Округление до 3 знаков

            string path = ds.SaveToFileTextData(x);

            // Проверка существования файла
            Assert.IsTrue(File.Exists(path));

            double result;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                result = reader.ReadDouble();
            }

            // Проверка содержимого файла
            Assert.AreEqual(wait, result);
        }
    }
}
