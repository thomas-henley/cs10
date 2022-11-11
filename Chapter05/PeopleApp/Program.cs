using Packt.Shared;
using System;
using static System.Console;

Person bob = new();
bob.Name = "Bob";
bob.DateOfBirth = new DateTime(1965, 12, 22);
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;

WriteLine($"{bob.Name} was born on {bob.DateOfBirth:dddd, d MMMM, yyyy}.");
WriteLine($"{bob.Name}'s favorite wonder is {bob.FavoriteAncientWonder}. Its integer is {(int)bob.FavoriteAncientWonder}.");