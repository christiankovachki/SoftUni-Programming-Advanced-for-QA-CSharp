namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Replace(" ", "");

            Dictionary<char, int> output = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];

                if (output.ContainsKey(c))
                {
                    output[c]++;
                }
                else
                {
                    output[c] = 1;
                }
            }

            foreach (var c in output)
            {
                Console.WriteLine($"{c.Key} -> {c.Value}");
            }

            // Using LINQ
            //output.Select(c => { Console.WriteLine($"{c.Key} -> {c.Value}"); return 1; }).ToList();
        }
    }
}