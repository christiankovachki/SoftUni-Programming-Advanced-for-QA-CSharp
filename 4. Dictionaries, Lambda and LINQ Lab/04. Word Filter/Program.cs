namespace _04._Word_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().Where(s => s.Length % 2 == 0).ToArray();

            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}