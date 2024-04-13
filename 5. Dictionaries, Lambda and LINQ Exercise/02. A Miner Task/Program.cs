namespace _02._A_Miner_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, int> output = new Dictionary<string, int>();

            while (!input.Equals("stop"))
            {
                string resource = input;
                int quantity = int.Parse(Console.ReadLine());

                if (output.ContainsKey(resource))
                {
                    output[resource] += quantity;
                }
                else
                {
                    output[resource] = quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var resource in output)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }

            // Using LINQ
            //output.Select(r => { Console.WriteLine($"{r.Key} -> {r.Value}"); return 1; }).ToArray();
        }
    }
}