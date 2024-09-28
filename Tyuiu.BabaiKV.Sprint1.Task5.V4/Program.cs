using Tyuiu.BabaiKV.Sprint1.Task5.V4.Lib;
namespace Tyuiu.BabaiKV.Sprint1.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите время: ");
            int time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = Convert.ToInt32(ds.SecondsToHours(time));
            Console.WriteLine( res);
            Console.ReadLine();
        }
    }
}
