using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BabaiKV.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            int cntr = 0;
            bool flag = false;
            foreach (char c in value)
            {
                if (c == value[0])
                {
                    cntr++;
                }
                if (cntr > 1)
                {
                    flag = true;
                    break;
                }

            }
            return flag;


        }
    }
}
