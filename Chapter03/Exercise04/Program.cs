// See https://aka.ms/new-console-template for more information

using static System.Console;

byte? number;
byte? anotherNumber;

try
{
    Write("Enter a number between 0 and 255: ");
    number = byte.Parse(ReadLine());
    Write("Enter another number between 0 and 255: ");
    anotherNumber = byte.Parse(ReadLine());

    WriteLine($"{number} / {anotherNumber} = {(double)number / (double)anotherNumber:N2}");
}
catch (FormatException ex)
{
    WriteLine($"{ex.Message} Use numbers.");
}
catch (OverflowException ex)
{
    WriteLine($"{ex.Message} Number must be in the range of 0 and 255.");
}
catch (Exception ex)
{
    WriteLine($"Unhandled exception: {ex}");
}
