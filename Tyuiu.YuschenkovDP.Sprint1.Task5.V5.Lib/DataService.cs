using tyuiu.cources.programming.interfaces.Sprint1;

using Tyuiu.YuschenkovDP.Sprint1.Task5.V5.Lib;

namespace Tyuiu.YuschenkovDP.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double fraction = x - Math.Truncate(x);
            int digit = (int)(fraction * 10);
            return digit;
        }

       
    }
}
