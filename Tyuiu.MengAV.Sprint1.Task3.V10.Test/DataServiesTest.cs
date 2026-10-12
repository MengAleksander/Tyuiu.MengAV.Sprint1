using Tyuiu.MengAV.Sprint1.Task3.V10.Lib;

namespace Tyuiu.MengAV.Sprint1.Task3.V10.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();
        [Fact]
        public void Test1()
        {
            string result = ds.NumberToMoney(23.6);

            Assert.Equal("23 руб. 60 коп.", result);
        }

        [Fact]
        public void Test2()
        {
            string result = ds.NumberToMoney(15);

            Assert.Equal("15 руб. 0 коп.", result);
        }

        [Fact]
        public void Test3()
        {
            string result = ds.NumberToMoney(4.05);

            Assert.Equal("4 руб. 5 коп.", result);
        }

        [Fact]
        public void Test4()
        {
            string result = ds.NumberToMoney(1.999);

            Assert.Equal("2 руб. 0 коп.", result);
        }
    }
}