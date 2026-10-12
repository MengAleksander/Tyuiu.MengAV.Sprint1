using Tyuiu.MengAV.Sprint1.Task1.V21.Lib;

namespace Tyuiu.MengAV.Sprint1.Task1.V21.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();
        [Fact]
        public void Test1()
        {
            double x = 6;
            double y = 3;

            double result = ds.Calculate(x, y);

            Assert.Equal(3, result);
        }
    }
}