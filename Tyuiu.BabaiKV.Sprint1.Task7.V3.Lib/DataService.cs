using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BabaiKV.Sprint1.Task7.V3.Lib
{
    public class DataService : ISprint1Task7V3

    {
        public double Calculate(double x, double y)
        {
            double res = ((3 + Math.Pow(Math.E, (y - 1))) / (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(x))));
            return Math.Round(res,3);
        }
    }
}
