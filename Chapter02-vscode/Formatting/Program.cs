int numberOfApples = 12;
decimal pricePerApple = 0.36M;
Console.WriteLine(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);
string formatted = string.Format(
    format: "{0} apples costs {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples
);
// WriteToFile(formatted); // writes the string into a file
// The WriteToFile method is a nonexistent method used to illustrate the idea.

Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

/*
For example, to output a table of fruit and how many of each there are, 
we might want to left-align the names within a column of 10 characters 
and right-align the counts formatted as numbers with zero decimal 
places within a column of six characters:
*/

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;
Console.WriteLine(
    format: "{0,-10} {1,6}",
    arg0: "Name",
    arg1: "Count"
);
Console.WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: applesText,
    arg1: applesCount
);
Console.WriteLine(
    format: "{0,-10} {1,6:N0}",
    arg0: bananasText,
    arg1: bananasCount
);

Console.WriteLine("----------------");

Console.Write("Type your first name and press ENTER:");
string? firstName = Console.ReadLine();
Console.Write("Type your age and press ENTER:");
string? age = Console.ReadLine();
Console.WriteLine($"Hello {firstName}, you look good for {age}.");