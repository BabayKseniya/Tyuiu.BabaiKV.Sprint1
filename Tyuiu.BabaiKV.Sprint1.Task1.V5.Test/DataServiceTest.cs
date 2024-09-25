using Tyuiu.BabaiKV.Sprint1.Task1.V5.Lib;
namespace Tyuiu.BabaiKV.Sprint1.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(7, res);
            

        }
    }
}