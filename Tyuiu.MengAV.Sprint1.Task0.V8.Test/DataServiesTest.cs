using Tyuiu.MengAV.Sprint1.Task0.V8.Lib;

namespace Tyuiu.MengAV.Sprint1.Task0.V8.Test
{
    public class DataServiesTest
    {
        [Fact]
        public void Test1()
        {
            DataServies ds = new DataServies();
            var res = ds.Calculate();
            Assert.Equal(1.875, res);
        }
    }
}
