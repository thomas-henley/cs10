using PacktLibrary;
using static System.Console;

Person harry = new() { Name = "Harry" };
Person mary = new() { Name = "Mary" };
Person jill = new() { Name = "Jill" };

// call instance methods
Person baby1 = mary.ProcreateWith(harry);
baby1.Name = "Gary";

// call static methods
Person baby2 = Person.Procreate(harry, jill);
Person baby3 = harry * mary;
WriteLine($"{harry.Name} has {harry.Children.Count} children.");
WriteLine($"{mary.Name} has {mary.Children.Count} children.");
WriteLine($"{jill.Name} has {jill.Children.Count} children.");
WriteLine(
    format: "{0}'s first child is named \"{1}\".",
    arg0: harry.Name,
    arg1: harry.Children.First().Name);

static void Harry_Shout(object? sender, EventArgs e)
{
    if (sender is null) return;
    Person p = (Person)sender;
    WriteLine($"{p.Name} is this angry: {p.AngerLevel}");
}

static void Harry_Shout_2(object? sender, EventArgs e)
{
    if (sender is null) return;
    Person p = (Person)sender;
    WriteLine($"{p.Name} says \"Alright, cut the shit buddy\"");
}

harry.Shout += Harry_Shout;
harry.Shout += Harry_Shout_2;

for (int i = 0; i < 4; i++)
{
    harry.Poke();
}

System.Collections.Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Alpha");
lookupObject.Add(key: 2, value: "Beta");
lookupObject.Add(key: 3, value: "Gamma");
lookupObject.Add(key: harry, value: "Delta");

int key = 2;
WriteLine(format: "Key {0} has value {1}",
    arg0: key,
    arg1: lookupObject[key]);

WriteLine(format: "Key {0} has value {1}",
    arg0: harry,
    arg1: lookupObject[harry]);

Person[] people =
{
    new() { Name = "Simon" },
    new() { Name = "Jenny" },
    new() { Name = "Adam" },
    new() { Name = "Richard" }
};
WriteLine("Initial list of people:");
foreach (Person p in people)
{
    WriteLine($"  {p.Name}");
}
WriteLine("Use Person's IComparable implementation to sort:");
Array.Sort(people);
foreach (Person p in people)
{
    WriteLine($"  {p.Name}");
}