namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (string word in bannedWords)
            {
                // This is way cleaner code
                if (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }

                // Older submission
                //string astericks = GetAstericks(word.Length);
                //int index = text.IndexOf(word);

                //while (index != -1)
                //{
                //    text = text.Replace(word, astericks);

                //    index = text.IndexOf(word);
                //}
            }

            Console.WriteLine(text);
        }

        static string GetAstericks(int length) 
        {
            string output = string.Empty;

            for (int i = 0; i < length; i++)
            {
                output += "*";
            }

            return output;
        }
    }
}