using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MengAV.Sprint1.Task2.V24.Lib
{
    public class DataServies : ISprint1Task2V24
    {
        public int CalculateDiffSquare(int value, int valueTwo)
        {
            int res = value - valueTwo;
            return res * res;
        }
    }
}
