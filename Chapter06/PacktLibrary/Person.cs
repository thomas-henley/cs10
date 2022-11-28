#nullable enable
using static System.Console;

namespace PacktLibrary;

public class Person : object, IComparable<Person>
{
    // fields
    public string? Name;
    public DateTime DateOfBirth;
    public List<Person> Children = new();

    // methods
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }

    public static Person Procreate(Person p1, Person p2)
    {
        Person baby = new()
        {
            Name = $"Baby of {p1.Name} and {p2.Name}"
        };
        p1.Children.Add(baby);
        p2.Children.Add(baby);
        return baby;
    }

    public static Person operator *(Person p1, Person p2)
    {
        return Procreate(p1, p2);
    }

    public Person ProcreateWith(Person partner)
    {
        return Procreate(this, partner);
    }

    // delegate field
    public event EventHandler? Shout;

    // data field
    public int AngerLevel;

    // method
    public void Poke()
    {
        AngerLevel++;
        if (AngerLevel >= 3)
        {
            Shout?.Invoke(this, EventArgs.Empty);
        }
    }

    public int CompareTo(Person? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        return string.Compare(Name, other.Name, StringComparison.Ordinal);
    }
}