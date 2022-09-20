// See https://aka.ms/new-console-template for more information

using static System.Console;
using static System.Convert;

// implicit cast
int a = 10;
double b = a;
WriteLine(b);

// explicit cast
double c = 2.94;
int d = (int)c;
WriteLine(d);

long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");
e = 5_000_000_000;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

double g = 9.8;
int h = ToInt32(g); // a method of System.Convert
WriteLine($"g is {g} and h is {h}");
WriteLine();

// demonstrates rounding in C#
double[] doubles = { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };

// Banker's Rounding
foreach (double n in doubles)
{
    WriteLine($"ToInt32({n}) is {ToInt32(n)}");
}
WriteLine();

// Away From Zero Rounding
foreach (double n in doubles)
{
    WriteLine(
        format: "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
        arg0: n,
        arg1: Math.Round(value: n, digits: 0,
            mode: MidpointRounding.AwayFromZero));
}
WriteLine();

// string converts
int number = 12;
WriteLine(number.ToString());

bool boolean = true;
WriteLine(boolean.ToString());

DateTime now = DateTime.Now;
WriteLine(now.ToString());

object me = new();
WriteLine(me.ToString());
WriteLine();

// converting from binary object to a string
// allocate array of 128 bits
byte[] binaryObject = new byte[128];

// populate with random bytes
(new Random()).NextBytes(binaryObject);

WriteLine("Binary Object as bytes:");

for (int index = 0; index < binaryObject.Length; index++)
{
    Write($"{binaryObject[index]:X}");
}
WriteLine();

// convert to Base64 string and output as text
string encoded = ToBase64String(binaryObject);

WriteLine($"Binary Object as Base64: {encoded}");
WriteLine();

// parsing from strings to numbers or dates and times
int age = int.Parse("41");
DateTime birthday = DateTime.Parse("2 June 1981");

WriteLine($"I was born {age} years ago.");
WriteLine($"My birthday is {birthday}");
WriteLine($"My birthday is {birthday:D}");

// using TryParse
Write("How many eggs are there? ");
string? input = ReadLine();

if (int.TryParse(input, out int count))
{
    WriteLine($"There are {count} eggs.");
}
else
{
    WriteLine("I could not parse the input.");
}