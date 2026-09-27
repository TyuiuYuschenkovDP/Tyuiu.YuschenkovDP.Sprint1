using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.YuschenkovDP.Sprint1.Task7.V14.Lib
{
    public class DataService : ISprint1Task7V14
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Pow(2, -x)
                       + (5 * x * x) / (3 * x * x * x)
                       - Math.Cos(x * x)
                       + Math.Sin(2 * x * y);
            return Math.Round(res, 3);
        }
    }
}