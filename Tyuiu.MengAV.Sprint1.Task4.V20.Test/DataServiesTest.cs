using Tyuiu.MengAV.Sprint1.Task4.V20.Lib;

namespace Tyuiu.MengAV.Sprint1.Task4.V20.Test
{
    public class DataServiesTest
    {
        [Fact]
        public void Test1()
        {
            double x = 1;
            double y = 2;

            double result = DataServies.Formula(x, y);

            Assert.Equal(2.0d, result, 3);
        }

        [Fact]
        public void Test2()
        {
            double x = Math.Sqrt(2);
            double y = 0;

            Assert.Throws<DivideByZeroException>(() => DataServies.Formula(x, y));
        }
    }
}