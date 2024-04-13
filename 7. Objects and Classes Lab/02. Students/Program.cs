namespace _02._Students
{
    internal class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

        public Student() { }

        public Student(string firstName, string secondName, int age, string homeTown) 
        {
            FirstName = firstName;
            LastName = secondName;
            Age = age;
            HomeTown = homeTown;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] studentInfo = input.Split().ToArray();
                string firstName = studentInfo[0];
                string lastName = studentInfo[1];
                int age = int.Parse(studentInfo[2]);
                string homeTown = studentInfo[3];

                Student student = new Student(firstName, lastName, age, homeTown);
                students.Add(student);

                input = Console.ReadLine();
            }

            string city = Console.ReadLine();

            students.Where(s => s.HomeTown.Equals(city))
                    .Select(s => 
                        { 
                            Console.WriteLine($"{s.FirstName} {s.LastName} is {s.Age} years old.");
                            return 1; 
                        })
                    .ToList();
        }
    }
}