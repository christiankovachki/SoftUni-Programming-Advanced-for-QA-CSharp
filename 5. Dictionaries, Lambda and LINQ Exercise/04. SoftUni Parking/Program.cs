namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> output = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string command = input[0];
                string username = input[1];

                if (command.Equals("register"))
                {
                    string licensePlateNumber = input[2];

                    if (output.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    else
                    {
                        output[username] = licensePlateNumber;
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                }
                else if (command.Equals("unregister"))
                {
                    if (output.ContainsKey(username))
                    {
                        output.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

            // Using LINQ
            //output.Select(item => { Console.WriteLine($"{item.Key} => {item.Value}"); return 1; }).ToArray();
        }
    }
}