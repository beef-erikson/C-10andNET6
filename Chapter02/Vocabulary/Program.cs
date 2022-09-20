// See https://aka.ms/new-console-template for more information
// #error version

using System.Reflection;

// Declare some unused variables using types to additional assemblies
System.Data.DataSet ds;
HttpClient client;

Assembly? assembly = Assembly.GetEntryAssembly();
if (assembly == null) return;

// Loop through the assemblies that this app references
foreach (AssemblyName name in assembly.GetReferencedAssemblies())
{
    // Load the assembly so we can read it's details
    Assembly a = Assembly.Load(name);

    int methodCount = 0;

    // Loop through all types in the assembly
    foreach (TypeInfo t in a.DefinedTypes)
    {
        methodCount += t.GetMethods().Count();
    }

    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount, arg2: name.Name);
}

// Note the use of nameof here
double heightInMetres = 1.88;
Console.WriteLine($"\nThe variable {nameof(heightInMetres)} has the value {heightInMetres}.");