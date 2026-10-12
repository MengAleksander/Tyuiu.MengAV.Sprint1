using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MengAV.Sprint1.Task1.V21.Lib
{
    public class DataServies : ISprint1Task1V21
    {
        public double Calculate(double x, double y)
        {
            if (3 + y == 0)
            {
                throw new DivideByZeroException("Знаменатель не может быть равен нулю.");
            }
            return (x * y) / (3 + y);
        }
    }
}
