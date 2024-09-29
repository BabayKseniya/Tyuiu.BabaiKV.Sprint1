using Tyuiu.BabaiKV.Sprint1.Task7.V3.Lib;
namespace Tyuiu.BabaiKV.Sprint1.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("              (y-1)  ");
            Console.WriteLine("         3+ e        ");
            Console.WriteLine("z = -----------------");
            Console.WriteLine("           2         ");
            Console.WriteLine("      1+ x    |y-tgx|");
            double x, y;
            Console.WriteLine("Введите значение x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(Math.Round(ds.Calculate(x, y),3));
            Console.ReadLine();
        }
    }
}
