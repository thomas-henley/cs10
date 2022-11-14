using Packt.Shared;
using System;
using static System.Console;

Person bob = new();
bob.Name = "Bob";
bob.DateOfBirth = new DateTime(1965, 12, 22);
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
bob.Children.Add(new Person { Name = "Alfred" });
bob.Children.Add(new() { Name = "Zoe" });
WriteLine($"{bob.Name} has {bob.Children.Count} children:");
foreach (Person child in bob.Children)
{
    WriteLine("  " + child.Name);
}

WriteLine($"{bob.Name} was born on {bob.DateOfBirth:dddd, d MMMM, yyyy}.");
WriteLine($"{bob.Name}'s favorite wonder is {bob.FavoriteAncientWonder}. Its integer is {(int)bob.FavoriteAncientWonder}.");