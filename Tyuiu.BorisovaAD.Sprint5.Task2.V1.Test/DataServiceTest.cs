using Tyuiu.BorisovaAD.Sprint5.Task2.V1.Lib;
namespace Tyuiu.BorisovaAD.Sprint5.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveAndReplaceOdd()
        {
            DataService ds = new DataService();

            int[,] matrix = new int { { 6, 9, 4 }, { 7, 2, 4 }, { 4, 8, 3 } };

            // Ожидаемый результат: "6;0;4\r\n0;2;4\r\n4;8;0"
            string expectedFileText = "6;0;4" + Environment.NewLine + "0;2;4" + Environment.NewLine + "4;8;0";

            string filePath = ds.SaveAndReplaceOdd(matrix);

            Assert.IsTrue(File.Exists(filePath));

            string actualFileText = File.ReadAllText(filePath);

            Assert.AreEqual(expectedFileText, actualFileText);

            File.Delete(filePath);
        }
    }
}
