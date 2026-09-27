using Tyuiu.YuschenkovDP.Sprint1.Task0.V22.Lib;

namespace Tyuiu.YuschenkovDP.Sprint1.Task0.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(1.875, res);
        }
    }
}
