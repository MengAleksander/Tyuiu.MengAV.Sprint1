using Tyuiu.MengAV.Sprint1.Task5.V6.Lib;

namespace Tyuiu.MengAV.Sprint1.Task5.V6.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();

        [Fact]
        public void ReturnsMonday()
        {
            Assert.Equal(1, ds.Calculate(1));
        }

        [Fact]
        public void ReturnsSunday()
        {
            Assert.Equal(7, ds.Calculate(7));
        }

        [Fact]
        public void ReturnsMondayNew()
        {
            Assert.Equal(1, ds.Calculate(8));
        }

        [Fact]
        public void ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => ds.Calculate(366));
        }
    }
}