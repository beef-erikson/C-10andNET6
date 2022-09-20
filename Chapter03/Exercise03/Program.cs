// See https://aka.ms/new-console-template for more information

using static System.Console;

for (int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        Write("fizzbuzz ");
    }
    else if (i % 3 == 0)
    {
        Write("fizz ");
    }
    else if (i % 5 == 0)
    {
        Write("buzz ");
    }
    else
    {
        Write($"{i} ");
    }
}
