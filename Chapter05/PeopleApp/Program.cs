﻿using Packt.Shared;
using static System.Console;

// Bank account info
BankAccount.interestRate = 0.012M;

BankAccount martinAccount = new();
martinAccount.AccountName = "Mr. Martin";
martinAccount.Balance = 140.33M;

WriteLine(format: "{0} earned {1:C} interest.",
    arg0: martinAccount.AccountName,
    arg1: martinAccount.Balance * BankAccount.interestRate);

BankAccount eriksonAccount = new();
eriksonAccount.AccountName = "Mr. Erikson";
eriksonAccount.Balance = 140_342.33M;

WriteLine(format: "{0} earned {1:C} interest.",
    arg0: eriksonAccount.AccountName,
    arg1: eriksonAccount.Balance * BankAccount.interestRate);

// Makes a new person, beef
Person beef = new();
beef.Name = "Beef";
beef.DateOfBirth = new(1981, 6, 2);
beef.FavoriteAncientWonder = WondersOfTheAncientWorld.GreatPyramidsOfGiza;

// beef.BucketList = (WondersOfTheAncientWorld)67
beef.BucketList = WondersOfTheAncientWorld.GreatPyramidsOfGiza |
    WondersOfTheAncientWorld.HangingGardensOfBabylon |
    WondersOfTheAncientWorld.ColossusOfRhodes;

// Talk about beef's species
WriteLine($"{beef.Name} is a {Person.Species}.");

// Make some kids
beef.Children.Add(new Person { Name = "Boot" });
beef.Children.Add(new() { Name = "Soup" });

// Talk about the children
WriteLine($"{beef.Name} has {beef.Children.Count} children: ");

for (int childIndex = 0; childIndex < beef.Children.Count; childIndex++)
{
    WriteLine($"    {beef.Children[childIndex].Name}");
}

foreach (Person child in beef.Children)
{
    WriteLine($"    {child.Name}");
}

// Bucket list
WriteLine($"{beef.Name}'s bucket list is {beef.BucketList}");

// Favorite wonder
WriteLine(
    format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
    arg0: beef.Name,
    arg1: beef.FavoriteAncientWonder,
    arg2: (int)beef.FavoriteAncientWonder);

// Birthday
WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}.",
    arg0: beef.Name,
    arg1: beef.DateOfBirth);

// Makes another person, boot using an object initializer (C# 9+)
Person foot = new()
{
    Name = "Foot",
    DateOfBirth = new(2023, 9, 15)
};

// Foot's birthday
WriteLine(format: "{0} was born on {1:dd MMM yy}.",
    arg0: foot.Name,
    arg1: foot.DateOfBirth);
