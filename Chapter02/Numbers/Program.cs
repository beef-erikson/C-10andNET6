﻿// See https://aka.ms/new-console-template for more information

// Unsigned integer means positive whole number or 0
uint naturalNumber = 23;

// integer means negative or positive whole number or 0
int integerNumber = -23;

// float means single-precision floating point
// F suffix makes it a float literal
float realNumber = 2.3F;

// double meanbs double-precision floating point
double anotherRealNumber = 2.3; //double literals

// three variables that store the number 2 million
int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

// check the three variables have the same value
// both statements output true
Console.WriteLine($"\n{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

Console.WriteLine($"\nint uses {sizeof(int)} bytes and can store numbers in the range " +
$"{int.MinValue:N0} to {int.MaxValue:N0}");
Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range " +
$"{double.MinValue:N0} to {double.MaxValue:N0}");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range " +
$"{decimal.MinValue:N0} to {decimal.MaxValue:N0}");

// Comparing doubles to decimal
Console.WriteLine("\nUsing doubles:");
double a = 0.1;
double b = 0.2;

if (a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does not equal {0.3}");
}

Console.WriteLine("\nUsing decimals:");
decimal c = 0.1M;   // M suffix means literal decimal
decimal d = 0.2M;

if (c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals {0.3M}");
}
else
{
    Console.WriteLine($"{c} + {d} does not equal {0.3M}");
}

// booleans
bool happy = true;
bool sad = false;