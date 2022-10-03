// See https://aka.ms/new-console-template for more information

using Packt.Shared;
using static System.Console;

// Makes a new person, beef
Person beef = new();
beef.Name = "Beef";
beef.DateOfBirth = new(1981, 6, 2);

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
