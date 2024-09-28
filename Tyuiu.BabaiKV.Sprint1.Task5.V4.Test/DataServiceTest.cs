using System.Globalization;
using Tyuiu.BabaiKV.Sprint1.Task5.V4.Lib;
namespace Tyuiu.BabaiKV.Sprint1.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpession()

        {
            int time = 75600;
            DataService ds = new DataService();
            int res = ds.SecondsToHours(time);
            Assert.AreEqual(21, res);
        }
    }
}