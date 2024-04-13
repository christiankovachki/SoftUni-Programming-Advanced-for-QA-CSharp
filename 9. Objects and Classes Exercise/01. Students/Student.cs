namespace _01._Students
{
    public class Student
    {
        private string _firstName;
        private string _lastName;
        private double _grade;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public double Grade { get => _grade; set => _grade = value; }

        public Student() { }

        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
    }
}