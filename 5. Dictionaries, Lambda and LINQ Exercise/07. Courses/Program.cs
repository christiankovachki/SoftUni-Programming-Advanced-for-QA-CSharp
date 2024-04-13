namespace _07._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>();

            while (!input.Equals("end"))
            {
                string[] data = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = data[0];
                string studentName = data[1];

                if (!output.ContainsKey(courseName))
                {
                    output.Add(courseName, new List<string>());
                }

                output[courseName].Add(studentName);

                input = Console.ReadLine();
            }

            foreach (var course in output)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                course.Value.ForEach(s => Console.WriteLine($"-- {s}"));
            }
        }
    }
}