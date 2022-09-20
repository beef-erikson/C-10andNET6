// See https://aka.ms/new-console-template for more information

using System.Xml;

object height = 1.88;   // storing a double in an object
object name = "beef";   // storing a string in an object
Console.WriteLine($"{name} is {height} meters tall");

// int length1 = name.Length;  // gives compiler error!
int length2 = ((string)name).Length;    // tell compiler it is a string
Console.WriteLine($"{name} has {length2} characters.");

// storing a string in a dynamic object
// string has a Length property
dynamic something = "Beef";

// int does not have a Length property
// something = 12;

// an array of any type has a Length property
// something = new[] { 3, 5, 7 };

// this compiles but would throw an exception at run-time
// if you later store a data type that does not have a 
// property named length
Console.WriteLine($"\nLength is {something.Length}.");

var population = 66_000_000; // 66 million in UK
var weight = 1.88; // in kilograms
var price = 4.99M; // in dollars
var fruit = "Apples"; // strings use double quotes
var letter = 'Z'; // chars use single quotes
var happy = true; // Booleans have values of true or false

// good use of var because it avoids the repeated type as shown in the more verbose second statement
var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();

// bad use of var because we cannot tell the type, so we should use a specific type
// declaration as shown in the second statement
var file1 = File.CreateText("something1.txt");
StreamWriter file2 = File.CreateText("something2.txt");

// target-typed new in C# 9 or later
XmlDocument xml3 = new();

/* Demonstration of using target-type new when setting a value
class Person
{
    public DateTime BirthDate;
}

Person kim = new();
kim.BirthDate = new(1967, 12, 26);
*/

// Display default values of various types
Console.WriteLine($"\ndefault(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

// Declaring a number then setting it back to it's default value
int number = 13;
Console.WriteLine($"\nnumber has been set to: {number}");
number = default;
Console.WriteLine($"number has been reset to its default of: {number}");

// Demonstration of arrays
string[] names; // can reference any size array of strings

// alloating memory for four string in the array
names = new string[4];

// storing names at index positions
names[0] = "Jack";
names[1] = "Kate";
names[2] = "Bill";
names[3] = "Beef";

Console.WriteLine();
// looping through the names
for (int i = 0; i < names.Length; i++)
{
    // output the line at index position i
    Console.WriteLine(names[i]);
}


// Alternate way to initialize arrays
string[] names2 = new[] { "Jack", "Kate", "Bill", "Beef" };
