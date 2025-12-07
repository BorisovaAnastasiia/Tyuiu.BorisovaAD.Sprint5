using Tyuiu.BorisovaAD.Sprint5.Task0.V12.Lib;
namespace Tyuiu.BorisovaAD.Sprint5.Task0.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            int x = 3;

            double wait = Math.Pow(3, 3) / (2 * Math.Pow(3 + 5, 2));
            wait = Math.Round(wait, 3);

            string path = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(path));

            string fileContent = File.ReadAllText(path);
            double result = double.Parse(fileContent);

            Assert.AreEqual(wait, result);
        }
    }
}
