using System;
using static System.Console;

namespace Packt.Shared
{
    public class Person : object // explicitly inheret from System.Object
    {
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
    }
}