namespace PrimeFactors;

public class PrimeFactorsLib
{
    string factors = "";

    /// <summary>
    /// Determines all the prime factors in a given number (accurate up to 1000)
    /// </summary>
    /// <param name="number">Integer to find all prime factors of</param>
    /// <returns>String of all prime factors.</returns>
    public string PrimeFactors(int number)
    {


        // Divide number by smallest prime number
        for (int i = 2; i <= 1_000; i++)
        {
            if (number % i != 0)
            {
                continue;
            }
            else if (number != 1)
            {
                Console.WriteLine($"Adding factor: {i}");
                factors += $"{i} ";
                number = number / i;
                Console.WriteLine($"Using number {number}");
                PrimeFactors(number);
            }

            return factors;
        }



        // Divide quotient by smallest prime number

        // Repeat until quotient becomes one

        // Multiply all prime factors should equal the same number

        return factors;
    }
}
