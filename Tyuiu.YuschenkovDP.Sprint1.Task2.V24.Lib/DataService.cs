using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.YuschenkovDP.Sprint1.Task2.V24.Lib
{
    public class DataService : ISprint1Task2V24
    {
        public int CalculateDiffSquare(int value, int valueTwo)
        {
            int diff = value - valueTwo;
            return diff * diff;
        }
    }
}
