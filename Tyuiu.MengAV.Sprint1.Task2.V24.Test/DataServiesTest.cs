using Tyuiu.MengAV.Sprint1.Task2.V24.Lib;

namespace Tyuiu.MengAV.Sprint1.Task2.V24.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();
        [Fact]
        public void Test1()
        {
            int x = 10;
            int y = 4;

            int result = ds.CalculateDiffSquare(x, y);

            Assert.Equal(36, result);
        }
    }
}