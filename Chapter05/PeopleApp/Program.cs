using Packt.Shared;
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
WriteLine($"{beef.Name} is a {Person.Species} that resides on {beef.HomePlanet}.");

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

// Make another person, this time default!
Person blankPerson = new();

WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: blankPerson.Name,
    arg1: blankPerson.HomePlanet,
    arg2: blankPerson.Instantiated);

// One more person for good measure!
Person shoe = new(
    initialName: "Shoe",
    homePlanet: "Mars");

WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: shoe.Name,
    arg1: shoe.HomePlanet,
    arg2: shoe.Instantiated);

// Prints date of birth and home planet
beef.WriteToConsole();
WriteLine(beef.GetOrigin());

// Use the tuple GetFruit
(string, int) fruit = beef.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

// Use the named tuple GetFruitNamed
var fruitNamed = beef.GetNamedFruit();
WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

// Inferring tuple names
var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");

var thing2 = (beef.Name, beef.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children.");