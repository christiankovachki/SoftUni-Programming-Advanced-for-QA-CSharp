using System.Collections;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();

            var output = new Dictionary<string, int>();

            foreach (string e in input)
            {
                if (output.ContainsKey(e))
                {
                    output[e]++;
                }
                else
                {
                    output[e] = 1;
                }
            }

            foreach (var e in output)
            {
                if (e.Value % 2 != 0)
                {
                    Console.Write($"{e.Key} ");
                }
            }
        }
    }
}