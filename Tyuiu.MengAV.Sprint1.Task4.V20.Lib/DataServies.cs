using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MengAV.Sprint1.Task4.V20.Lib
{
    public class DataServies : ISprint1Task4V20
    {
        public double Calculate(double x, double y)
        {
            double znam = Math.Abs(x - Math.Sqrt(2 + Math.Abs(y)));

            if (znam == 0)
            {
                throw new DivideByZeroException("Знаменатель не может быть равен нулю.");
            }

            return (1 + x) / znam;
        }
    }
}
