// See https://aka.ms/new-console-template for more information

using Packt.Shared;
using static System.Console;

// Makes a new person, beef
Person beef = new();
beef.Name = "Beef";
beef.DateOfBirth = new(1981, 6, 2);
beef.FavoriteAncientWonder = WondersOfTheAncientWorld.GreatPyramidsOfGiza;

// beef.BucketList = (WondersOfTheAncientWorld)67
beef.BucketList = WondersOfTheAncientWorld.GreatPyramidsOfGiza |
    WondersOfTheAncientWorld.HangingGardensOfBabylon |
    WondersOfTheAncientWorld.ColossusOfRhodes;

WriteLine($"{beef.Name}'s bucket list is {beef.BucketList}");

WriteLine(
    format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
    arg0: beef.Name,
    arg1: beef.FavoriteAncientWonder,
    arg2: (int)beef.FavoriteAncientWonder);

WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}.",
    arg0: beef.Name,
    arg1: beef.DateOfBirth);

// Makes another person, boot using an object initializer (C# 9+)
Person boot = new()
{
    Name = "Boot",
    DateOfBirth = new(2023, 9, 15)
};

WriteLine(format: "{0} was born on {1:dd MMM yy}.",
    arg0: boot.Name,
    arg1: boot.DateOfBirth);
