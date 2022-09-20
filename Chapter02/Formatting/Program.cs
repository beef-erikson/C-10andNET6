// See https://aka.ms/new-console-template for more information

using static System.Console;

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

WriteLine(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

string formatted = string.Format(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples);

//WriteToFile(formatted); // writes the string into a file (non-existant demo method)

// Interpolated string
WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

// Formatting examples
string applesText = "Apples";
int applesCount = 1234;

string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine(
    format: "\n{0,-10} {1,6}",
    arg0: "Name",
    arg1: "Count");

WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: applesText,
    arg1: applesCount);

WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: bananasText,
    arg1: bananasCount);

// Input example
Write("\nType your first name and press ENTER: ");
string? firstName = ReadLine();

Write("Type your age and hit ENTER: ");
string? age = ReadLine();

WriteLine($"Hello {firstName}, you look good for being {age}!");

// Reading key presses
Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine("\nKey: {0}, Char: {1}, Modifiers: {2}",
    arg0: key.Key,
    arg1: key.KeyChar,
    arg2: key.Modifiers);