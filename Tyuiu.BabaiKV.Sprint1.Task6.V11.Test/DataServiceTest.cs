using Tyuiu.BabaiKV.Sprint1.Task6.V11.Lib;
namespace Tyuiu.BabaiKV.Sprint1.Task6.V11.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidExpression()

        {
            string strTest = "mama"; 
            DataService ds = new DataService();
            bool res = ds.CheckeFirstLetterRepetition(strTest);
            Assert.AreEqual(true, res);
        }
    }
}