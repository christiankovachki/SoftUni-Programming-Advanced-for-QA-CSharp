namespace Players;

public class Hero
{
    private string? _username = null!;
    private int _level = 0;

    public string Username { get => _username; set => _username = value; }
    public int Level { get => _level; set => _level = value; }

    public Hero(string username, int level)
    {
        Username = username;
        Level = level;
    }

    public override string ToString()
    {
        return $"Type: {GetType().Name} Username: {Username} Level: {Level}";
    }
}