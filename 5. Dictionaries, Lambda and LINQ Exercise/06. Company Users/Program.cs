namespace _06._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var output = new Dictionary<string, List<string>>();

            while (!input.Equals("End"))
            {
                string[] inputSplit = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string companyName = inputSplit[0];
                string employeeId = inputSplit[1];

                if (output.ContainsKey(companyName))
                {
                    if (!output[companyName].Contains(employeeId))
                    {
                        output[companyName].Add(employeeId);
                    }
                }
                else
                {
                    output.Add(companyName, new List<string>());
                    output[companyName].Add(employeeId);
                }

                input = Console.ReadLine();
            }

            foreach (var company in output)
            {
                Console.WriteLine(company.Key);
                company.Value.ForEach(id => Console.WriteLine($"-- {id}"));
            }
        }
    }
}