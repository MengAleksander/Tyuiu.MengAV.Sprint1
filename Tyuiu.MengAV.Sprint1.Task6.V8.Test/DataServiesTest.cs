using Tyuiu.MengAV.Sprint1.Task6.V8.Lib;

namespace Tyuiu.MengAV.Sprint1.Task6.V8.Test
{
    public class DataServiesTest
    {
        [Fact]
        public void MovesWord()
        {
            string text = "Мама мыла раму";

            string res = DataServies.Word(text);

            Assert.Equal("амаМ ылам амур", res);
        }

        [Fact]
        public void NoMovesCar()
        {
            string result = DataServies.Word("А я");

            Assert.Equal("А я", result);
        }

        [Fact]
        public void Void()
        {
            string result = DataServies.Word("");

            Assert.Equal(string.Empty, result);
        }
    }
}