using Newtonsoft.Json.Linq;
using Tyuiu.MengAV.Sprint1.Task6.V8.Lib;

namespace Tyuiu.MengAV.Sprint1.Task6.V8.Test
{
    public class DataServiesTest
    {
        DataServies ds = new DataServies();
        [Fact]
        public void MovesWord()
        {
            string value = "Мама мыла раму";

            string res = ds.MoveLetterToEnd(value);

            Assert.Equal("амаМ ылам амур", res);
        }

        [Fact]
        public void NoMovesCar()
        {
            string res = ds.MoveLetterToEnd("А я");

            Assert.Equal("А я", res);
        }

        [Fact]
        public void Void()
        {
            string res = ds.MoveLetterToEnd("");

            Assert.Equal(string.Empty, res);
        }
    }
}