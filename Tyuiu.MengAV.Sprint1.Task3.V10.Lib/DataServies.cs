namespace Tyuiu.MengAV.Sprint1.Task3.V10.Lib
{
    public class DataServies
    {
        public static decimal Number(decimal num)
        {
            return decimal.Round(num, 3);
        }

        public static int Rubles(decimal num)
        {
            decimal rub = Number(num);

            return (int)decimal.Truncate(rub);
        }

        public static int Kopecks(decimal num)
        {
            decimal rub = Number(num);

            decimal kop = rub - decimal.Truncate(rub);

            return (int)decimal.Round(kop * 100, 0);
        }
    }
}
