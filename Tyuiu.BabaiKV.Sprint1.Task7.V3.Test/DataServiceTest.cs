using Tyuiu.BabaiKV.Sprint1.Task7.V3.Lib;
namespace Tyuiu.BabaiKV.Sprint1.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 1;
            var res = ds.Calculate(x,y);
            Assert.AreEqual(2.568, res);
        }
    }
}