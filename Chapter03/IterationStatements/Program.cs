// See https://aka.ms/new-console-template for more information

using static System.Console;

// loops from 0 to 9
int x = 0;

while (x < 10)
{
    WriteLine(x);
    x++;
}

// same as while but executes loop always at least once
string? password;
x = 5;
do
{
    Write("Enter your password: ");
    password = ReadLine();

    if (password != "Pa$$w0rd")
    {
        x--;
        WriteLine($"You have {x} attempts remaining.");

        if (x <= 0)
        {
            WriteLine("You have run out of password attempts.");
            break;
        }
    }
}
while (password != "Pa$$w0rd");

if (password == "Pa$$w0rd")
{
    WriteLine("Correct!");
}
else
{
    WriteLine("Goodbye.");
}

// Count 1 to 10 in for loop
for (int y = 1; y <= 10; y++)
{
    WriteLine(y);
}

// use foreach when looping through something iterable (arrays, collections, etc).
// note this will be read-only
string[] names = { "Beef", "Boot", "Foot", "Soup" };

foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}