using Tyuiu.MengAV.Sprint1.Task5.V6.Lib;

namespace Tyuiu.MengAV.Sprint1.Task5.V6.Test
{
    public class DataServiesTest
    {
        [Fact]
        public void Ponidelnic()
        {
            int daynam = DataServies.DayNumber(1);

            Assert.Equal(1, daynam);
        }

        [Fact]
        public void Voskresenie()
        {
            int daynam = DataServies.DayNumber(7);

            Assert.Equal(7, daynam);
        }

        [Fact]
        public void Vtoroi_Ponidelnic()
        {
            int daynam = DataServies.DayNumber(8);

            Assert.Equal(1, daynam);
        }

        [Fact]
        public void Error()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                () => DataServies.DayNumber(366)
            );
        }
    }
}