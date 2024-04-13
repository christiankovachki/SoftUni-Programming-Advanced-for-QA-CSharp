using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(?<number>\+359(\s|-)2\1\d{3}\1\d{4}\b)";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);
            List<string> validPhones = new List<string>(matches.Count);

            foreach (Match match in matches) 
            {
                validPhones.Add(match.Groups["number"].Value);
            }

            Console.Write(string.Join(", ", validPhones));
        }
    }
}