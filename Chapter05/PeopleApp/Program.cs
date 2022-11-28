using Packt.Shared;
using static System.Console;


Person bob = new()
{
    Name = "Bob",
    DateOfBirth = new DateTime(1965, 12, 22),
    FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia
};

WriteLine($"{bob.Name} was born on {bob.DateOfBirth:dddd, d MMMM, yyyy}.");
WriteLine(
    $"{bob.Name}'s favorite wonder is {bob.FavoriteAncientWonder}. Its integer is {(int)bob.FavoriteAncientWonder}.");

int a = 10;
int b = 20;
WriteLine($"Before: a = {a}, b = {b}, c = ");
bob.PassingParameters(a, ref b, out int c);
WriteLine($"After: a = {a}, b = {b}, c = {c}");

Person sam = new();

sam.Children.Add(new() { Name = "Charlie" });
sam.Children.Add(new() { Name = "Ella" });
WriteLine($"Sam's first child is {sam.Children[0].Name}");
WriteLine($"Sam's second child is {sam.Children[1].Name}");
WriteLine($"Sam's first child is {sam[0].Name}");
WriteLine($"Sam's second child is {sam[1].Name}");