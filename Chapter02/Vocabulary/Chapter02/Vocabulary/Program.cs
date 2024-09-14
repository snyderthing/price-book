using System.Reflection;
// declare some unused variables using types
// in additional assemblies
System.Data.DataSet ds;
HttpClient client;
// See https://aka.ms/new-console-template for more information
// #error version

Assembly? assembly = Assembly.GetEntryAssembly();
if (assembly == null) return;
// loop through the assemblies that this app references
foreach (AssemblyName name in assembly.GetReferencedAssemblies())
{
    // load the assembly so we can read its details
    Assembly a = Assembly.Load(name);
    // declare a variable to count the number of methods
    int methodCount = 0;
    // loop through all the types in the assembly
    foreach (TypeInfo t in a.DefinedTypes)
    {
        // add up the counts of methods
        methodCount += t.GetMethods().Count();
    }
    // output the count of types and their methods
    Console.WriteLine(
        "{0:N0} types with {1:N0} methods in {2} assembly.",
        arg0: a.DefinedTypes.Count(),
        arg1: methodCount,
        arg2: name.Name);
}

double heightInMetres = 1.88;
Console.WriteLine($"The variable {nameof(heightInMetres)} has the value {heightInMetres}.");

char letter = 'A';// assigning literal characters
char digit = '1';
char symbol = '$';
// char userChoice = GetSomeKeystroke(); // assigning from a fictitious function
string firstName = "Bob"; // assigning literal strings
string lastName = "Smith";
string phoneNumber = "(215) 555-4256";
// assigning a string returned from a fictitious function
// string address = GetAddressFromDatabase(IDictionary: 563);