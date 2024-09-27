using Tyuiu.BabaiKV.Sprint1.Task3.V1.Lib;
namespace Tyuiu.BabaiKV.Sprint1.Task3.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double r = 1;
            double h = 2;
            Console.WriteLine("Радиус цилиндра r: " +r);
            Console.WriteLine("Высота цилиндра h: " +h);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Объём цилиндра : " + ds.CylinderVolume(r,h));
            Console.ReadLine();
        }
    }
}
