namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();

            SortedDictionary<int, int> numbers = new SortedDictionary<int, int>();

            foreach (var num in integers)
            {
                if (numbers.ContainsKey(num))
                {
                    numbers[num]++;
                }
                else
                {
                    numbers.Add(num, 1);
                }
            }

            foreach (var num in numbers)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}