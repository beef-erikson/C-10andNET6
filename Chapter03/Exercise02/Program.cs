// See https://aka.ms/new-console-template for more information

using static System.Console;

int max = 500;
for (byte i = 0; i < max; i++)
{
    if (i >= byte.MaxValue)
    {
        WriteLine($"{i} has reached the max byte value of {byte.MaxValue}.");
        break;
    }
    WriteLine(i);
}