using Tyuiu.BabaiKV.Sprint1.Task2.V29.Lib;
namespace Tyuiu.BabaiKV.Sprint1.Task2.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x;
            Console.WriteLine("Время в секундах : "); 
            x= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Время в минутах: " + ds.ConvertSecondsToHours(x));
            Console.ReadLine();

        }
    }
}
