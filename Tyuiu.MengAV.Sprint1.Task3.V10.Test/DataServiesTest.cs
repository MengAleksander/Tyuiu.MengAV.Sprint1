using Tyuiu.MengAV.Sprint1.Task3.V10.Lib;

namespace Tyuiu.MengAV.Sprint1.Task3.V10.Test
{
    public class DataServiesTest
    {
        [Fact]
        public void Test1()
        {
            decimal mon = 23.6457m;

            decimal res = DataServies.Number(mon);

            Assert.Equal(23.646m, res);
        }

        [Fact]
        public void Test2()
        {
            decimal mon = 23.6m;

            int rub = DataServies.Rubles(mon);
            int kop = DataServies.Kopecks(mon);

            Assert.Equal(23, rub);
            Assert.Equal(60, kop);
        }
    }
}