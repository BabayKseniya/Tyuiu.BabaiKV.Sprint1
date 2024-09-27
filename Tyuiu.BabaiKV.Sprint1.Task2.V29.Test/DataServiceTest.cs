using Tyuiu.BabaiKV.Sprint1.Task2.V29.Lib;
namespace Tyuiu.BabaiKV.Sprint1.Task2.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 120;
            var res = ds.ConvertSecondsToHours(x);
            Assert.AreEqual(2,res);
        }
    }
}