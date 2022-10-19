using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public class Person : object // explicitly inheret from System.Object
    {
        // Fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();
        public const string Species = "Homo Sapien";
        // sometimes readonly is a better solution to const
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        // Constructors
        /// <summary>
        /// Constructor with default values.
        /// </summary>
        public Person()
        {
            // set default values for fields
            // including readonly fields
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        /// <summary>
        /// Constructor with parameters for Name and HomePlanet.
        /// </summary>
        /// <param name="initialName">string for Name.</param>
        /// <param name="homePlanet">string for HomePlanet.</param>
        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        // Methods
        /// <summary>
        /// Prints name and day of birth.
        /// </summary>
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        /// <summary>
        /// Returns Name and HomePlanet of Person.
        /// </summary>
        /// <returns>string with name and home planet.</returns>
        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        /// <summary>
        /// Returns tuple of Apples and 5.
        /// </summary>
        /// <returns>string and int of fruit.</returns>
        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }
    }
}