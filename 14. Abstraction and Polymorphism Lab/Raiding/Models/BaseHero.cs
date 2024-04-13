using Raiding.Contracts;

namespace Raiding.Models;

public abstract class BaseHero : IHero
{
    public BaseHero(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public abstract int Power { get; }

    public virtual string CastAbility()
    {
        return $"{GetType().Name} - {Name}";
    }
}