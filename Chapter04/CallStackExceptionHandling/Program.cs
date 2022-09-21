// See https://aka.ms/new-console-template for more information

using Packt;
using static System.Console;

WriteLine("In main");
Alpha();

static void Alpha()
{
    WriteLine("In alpha");
    Beta();
}

static void Beta()
{
    WriteLine("In beta");

    try
    {
        Calculator.Gamma();
    }
    catch (Exception ex)
    {
        WriteLine($"Caught this: {ex.Message}");
        throw;
    }
}