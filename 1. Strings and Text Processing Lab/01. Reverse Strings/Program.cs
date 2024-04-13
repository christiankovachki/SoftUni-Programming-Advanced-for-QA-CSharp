namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (!input.Equals("end"))
            {
                string reversedWord = new string(input.ToCharArray().Reverse().ToArray());

                Console.WriteLine($"{input} = {reversedWord}");

                input = Console.ReadLine();
            }
        }
    }
}