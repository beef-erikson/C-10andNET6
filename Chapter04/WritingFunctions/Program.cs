// See https://aka.ms/new-console-template for more information

using static System.Console;

TimesTable(65);
WriteLine();

decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "PA");
WriteLine($"You must pay {taxToPay:C} in taxes.");
WriteLine();

for (int i = 1; i <= 40; i++)
{
    WriteLine($"{CardinalToOrdinal(i)}");
}
WriteLine();

RunFactorial();
WriteLine();

RunFibImperative();
WriteLine();

RunFibFunctional();

/// <summary>
/// Writes out a times table based on the provided number (0 - 255) up to the 12th row.
/// </summary>
/// <param name="number">Number to multiply by.</param>
static void TimesTable(byte number)
{
    WriteLine($"This is the {number} times table.");
    for (int row = 1; row <= 12; row++)
    {
        WriteLine($"{row} x {number} = {row * number}");
    }
    WriteLine();
}

/// <summary>
/// Calculate sales tax
/// </summary>
/// <param name="amount">Amount to tax</param>
/// <param name="twoLetterRegionCode">Region code to apply tax (i.e. PA)</param>
/// <returns>Sales tax based on amount given</returns>
static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
{
    decimal rate = 0.0M;

    switch (twoLetterRegionCode)
    {
        case "CH":  // Switzerland
            rate = 0.08M;
            break;
        case "DK":  // Denmark
        case "NO":  // Norway
            rate = 0.25M;
            break;
        case "GB":  // Great Brittain
        case "FR":  // France
            rate = 0.2M;
            break;
        case "HU":  // Hungary
            rate = 0.27M;
            break;
        case "OR":  // Orgeon
        case "AK":  // Alaska
        case "MT":  // Montana
            rate = 0.0M;
            break;
        case "ND":  // North Dakota
        case "WI":  // Wisconsin
        case "ME":  // Maine
        case "VA":  // Virginia
            rate = 0.05M;
            break;
        case "CA":  // California
            rate = 0.0825M;
            break;
        default:   // Most US States
            rate = 0.06M;
            break;
    }

    return amount * rate;
}

/// <summary>
/// Coverts cardinal numbers to ordinal numbers (1 to 1st)
/// </summary>
/// <param name="number">number to convert</param>
/// <returns>converted number</returns>
static string CardinalToOrdinal(int number)
{
    switch (number)
    {
        case 11:    // special cases for 11th to 13th
        case 12:
        case 13:
            return $"{number}th";
        default:
            int lastDigit = number % 10;

            string suffix = lastDigit switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
            return $"{number}{suffix}";
    }
}

/// <summary>
/// Returns the factorial on the given number
/// </summary>
/// <param name="number">Number to find the factorial of</param>
/// <returns>Factorial of provided number</returns>`
static int Factorial(int number)
{
    if (number < 1)
    {
        return 0;
    }
    else if (number == 1)
    {
        return 1;
    }
    else
    {
        checked // for overflow
        {
            return number * Factorial(number - 1);
        }
    }
}

/// <summary>
/// Runs a factorial for the numbers 1 - 15
/// </summary>
static void RunFactorial()
{
    for (int i = 1; i < 15; i++)
    {
        try
        {
            WriteLine($"{i}! = {Factorial(i):N0}");
        }
        catch (System.OverflowException)
        {
            WriteLine($"{i}! is too big for a 32-bit integer.");
        }
    }
}

/// <summary>
/// Using iperative function to display fibonacci sequence
/// </summary>
/// <param name="term">Term to use for the sequence</param>
/// <returns>The fibonacci number</returns>
static int FibImperative(int term)
{
    if (term == 1)
    {
        return 0;
    }
    else if (term == 2)
    {
        return 1;
    }
    else
    {
        return FibImperative(term - 1) + FibImperative(term - 2);
    }
}

/// <summary>
/// Runs FibImperative with the terms 1-30
/// </summary>
static void RunFibImperative()
{
    for (int i = 1; i <= 30; i++)
    {
        WriteLine("The {0} term of the Fibanocci sequence is {1:N0}.",
            arg0: CardinalToOrdinal(i),
            arg1: FibImperative(term: i));
    }
}

/// <summary>
/// Using functional in a declaritive style to display fibonacci sequence
/// </summary>
/// <param name="term">Term to use for the sequence</param>
/// <returns>The fibonacci number</returns>
static int FibFunctional(int term) =>
    term switch
    {
        1 => 0,
        2 => 1,
        _ => FibFunctional(term - 1) + FibFunctional(term - 2)
    };

/// <summary>
/// Runs FibFunctional with the terms 1-30
/// </summary>
static void RunFibFunctional()
{
    for (int i = 1; i <= 30; i++)
    {
        WriteLine("The {0} term of the Fibanocci sequence is {1:N0}.",
            arg0: CardinalToOrdinal(i),
            arg1: FibFunctional(term: i));
    }
}