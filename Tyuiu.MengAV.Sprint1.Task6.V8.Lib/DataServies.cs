using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;

namespace Tyuiu.MengAV.Sprint1.Task6.V8.Lib
{
    public class DataServies : ISprint1Task6V8
    {
        public string MoveLetterToEnd(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return string.Empty;
            }

            string[] words = value.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (word.Length > 1)
                {
                    words[i] = word.Substring(1) + word[0];
                }
            }

            return string.Join(" ", words);
        }
    }
}
