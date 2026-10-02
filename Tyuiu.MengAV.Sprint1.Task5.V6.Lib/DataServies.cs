namespace Tyuiu.MengAV.Sprint1.Task5.V6.Lib
{
    public class DataServies
    {
        public static int DayNumber(int k)
        {
            if (k < 1 || k > 365)
            {
                throw new ArgumentOutOfRangeException(nameof(k),"Номер дня должен быть от 1 до 365.");
            }

            return ((k - 1) % 7) + 1;
        }

        public static string DayName(int daynum)
        {
            string[] days =
            {
                "понедельник",
                "вторник",
                "среда",
                "четверг",
                "пятница",
                "суббота",
                "воскресенье"
            };

            return days[daynum - 1];
        }
    }
}
