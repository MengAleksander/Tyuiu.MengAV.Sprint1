using Tyuiu.MengAV.Sprint1.Task7.V18.Lib;

namespace Tyuiu.MengAV.Sprint1.Task7.V18.Test
{
    public class DataServiesTest
    {
        [Fact]
        public void Zero()
        {
            double x = 0;
            double y = 0;

            double res = DataServies.Formula(x, y);

            Assert.Equal(0.5, res, 3);
        }

        [Fact]
        public void CorrectResult()
        {
            double x = 1;
            double y = 0;

            double res = DataServies.Formula(x, y);

            Assert.Equal(1.569, res, 3);
        }
    }
}