namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();

            for (int i = 0; i < strings.Length; i++)
            {

                for (int j = 0; j < strings[i].Length; j++)
                {
                    Console.Write($"{strings[i]}");
                }
            }
        }
    }
}