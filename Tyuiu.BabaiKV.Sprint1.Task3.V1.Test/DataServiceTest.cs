using Tyuiu.BabaiKV.Sprint1.Task3.V1.Lib;
namespace Tyuiu.BabaiKV.Sprint1.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double r = 1;
            double h = 2;
            var res = ds.CylinderVolume(r,h);
            Assert.AreEqual(6.28,res);
        }
    }
}