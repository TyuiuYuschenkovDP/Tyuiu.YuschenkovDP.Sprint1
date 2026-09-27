using Tyuiu.YuschenkovDP.Sprint1.Task3.V5.Lib;

namespace Tyuiu.YuschenkovDP.Sprint1.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double scale = 120;
            double distanceOnMap = 3.5;
            var res = ds.DistanceLength(scale, distanceOnMap);
            Assert.AreEqual(420, res);
        }
    }
}
