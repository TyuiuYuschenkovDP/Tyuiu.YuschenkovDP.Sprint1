using Tyuiu.YuschenkovDP.Sprint1.Task2.V24.Lib;

namespace Tyuiu.YuschenkovDP.Sprint1.Task2.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 2;
            var res = ds.CalculateDiffSquare(x, y);
            Assert.AreEqual(9, res);

        }
    }
}
