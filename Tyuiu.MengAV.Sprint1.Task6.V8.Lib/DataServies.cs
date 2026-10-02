namespace Tyuiu.MengAV.Sprint1.Task6.V8.Lib
{
    public class DataServies
    {
        public static string Word(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return string.Empty;
            }

            string[] words = text.Split(' ',StringSplitOptions.RemoveEmptyEntries);

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
