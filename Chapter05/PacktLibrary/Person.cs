using System;
using System.Collections.Generic;
using static System.Console;

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

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        // methods
        /// <summary>
        /// Prints name and day of birth.
        /// </summary>
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        /// <summary>
        /// Returns Name and HomePlanet of Person
        /// </summary>
        /// <returns>string with name and home planet.</returns>
        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }
    }
}