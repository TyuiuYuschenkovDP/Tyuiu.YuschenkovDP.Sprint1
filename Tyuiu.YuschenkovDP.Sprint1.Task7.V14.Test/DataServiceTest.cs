using Tyuiu.YuschenkovDP.Sprint1.Task7.V14.Lib;

namespace Tyuiu.YuschenkovDP.Sprint1.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 0.87;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}