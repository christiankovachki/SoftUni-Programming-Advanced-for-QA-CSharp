namespace _03._Teamwork_Projects
{
    public class Team
    {
        private string _name;
        private string _creator;
        private List<string> _members;

        public string Name { get => _name; set => _name = value; }
        public string Creator { get => _creator; set => _creator = value; }
        public List<string> Members { get => _members; set => _members = value; }

        public Team() { }

        public Team(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }
    }
}