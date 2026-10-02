namespace Tyuiu.MengAV.Sprint1.Task1.V21.Lib
{
    public class DataServies
    {
        public static double Yravnenie(double x, double y)
        {
            if (3 + y == 0)
            {
                throw new DivideByZeroException(
                    "Знаменатель не может быть равен нулю."
                );
            }
            return (x * y) / (3 + y);
        }
    }
}
