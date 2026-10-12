using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MengAV.Sprint1.Task5.V6.Lib
{
    public class DataServies : ISprint1Task5V6
    {
        public int Calculate(int k)
        {
            if (k < 1 || k > 365)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(k),
                    "Номер дня должен быть от 1 до 365.");
            }

            return ((k - 1) % 7) + 1;
        }
    }
}
