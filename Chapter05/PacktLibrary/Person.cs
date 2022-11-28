using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person : object
    {
        // Fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public List<Person> Children = new List<Person>();

        public void PassingParameters(int x, ref int y, out int z)
        {
            // out parameters cannot have a default AND must be initialized inside the method
            z = 99;
            x++;
            y++;
            z++;
        }

        // indexers
        public Person this[int index]
        {
            get => Children[index]; // pass on to the List<T> indexer
            set => Children[index] = value;
        }
    }
}