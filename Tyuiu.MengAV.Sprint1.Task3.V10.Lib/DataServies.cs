using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MengAV.Sprint1.Task3.V10.Lib
{
    public class DataServies : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            decimal rounded = decimal.Round(
        (decimal)number, 3, MidpointRounding.AwayFromZero);

            long totalKopecks = decimal.ToInt64(
                decimal.Round(rounded * 100, 0, MidpointRounding.AwayFromZero));

            string sign = totalKopecks < 0 ? "-" : "";
            long absoluteKopecks = Math.Abs(totalKopecks);

            long rub = absoluteKopecks / 100;
            long kop = absoluteKopecks % 100;

            return $"{sign}{rub} руб. {kop} коп.";
        }
    }
}
