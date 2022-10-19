using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person : object // explicitly inheret from System.Object
    {
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();
        public const string Species = "Homo Sapien";
        // sometimes readonly is a better solution to const
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        // constructors
        public Person()
        {
            // set default values for fields
            // including readonly fields
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }
    }
}