namespace _01._Students
{
    public class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 1; i <= countOfStudents; i++)
            {
                string[] studentsInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string firstName = studentsInfo[0];
                string lastName = studentsInfo[1];
                double grade = double.Parse(studentsInfo[2]);

                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }

            students.OrderByDescending(s => s.Grade)
                    .Select(s =>
                    {
                        Console.WriteLine($"{s.FirstName} {s.LastName}: {s.Grade:F2}");

                        return 1;
                    })
                    .ToList();
        }
    }
}