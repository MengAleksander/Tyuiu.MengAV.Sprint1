namespace Tyuiu.MengAV.Sprint1.Task7.V18.Lib
{
    public class DataServies
    {
        public static double Formula(double x, double y)
        {
            double sinVal = Math.Sin(x + y);
            double sinSq = sinVal * sinVal;

            double fract = (2 * x) / (1 + x * x * y * y);

            double denom = 2 + Math.Abs(x - fract);

            return (1 + sinSq) / denom + x;
        }
    }
}
