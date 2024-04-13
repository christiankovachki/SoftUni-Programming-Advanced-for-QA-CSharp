namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstStr = Console.ReadLine();
            string secondStr = Console.ReadLine();

            int index = secondStr.IndexOf(firstStr);
            while (index != -1)
            {
                secondStr = secondStr.Remove(index, firstStr.Length);

                index = secondStr.IndexOf(firstStr);
            }

            Console.WriteLine(secondStr);
        }
    }
}