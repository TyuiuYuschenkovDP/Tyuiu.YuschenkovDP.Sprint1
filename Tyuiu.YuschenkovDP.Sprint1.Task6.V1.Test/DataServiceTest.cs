using Tyuiu.YuschenkovDP.Sprint1.Task6.V1.Lib;

namespace Tyuiu.YuschenkovDP.Sprint1.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            string res = ds.SymbolCode("1");
            Assert.AreEqual("Символ: 1 Код: 49", res);
        }
    }
}