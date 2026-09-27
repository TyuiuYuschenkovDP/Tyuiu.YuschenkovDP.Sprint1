using Tyuiu.YuschenkovDP.Sprint1.Task4.V21.Lib;

namespace Tyuiu.YuschenkovDP.Sprint1.Task4.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 1.2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
