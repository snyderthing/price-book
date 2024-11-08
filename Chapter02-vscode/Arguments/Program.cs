using static System.Console;
WriteLine($"There are {args.Length} arguments.");

foreach (string arg in args)
{
    WriteLine(arg);
}

WriteLine("---------------");

if(args.Length < 3)
{
    WriteLine("You must specify two colors and cursor size, e.g.");
    WriteLine("dotnet run red yellow 50");
    return; // stop running
}
ForegroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[0],
    ignoreCase: true
);
BackgroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[1],
    ignoreCase: true
);
try
{
    CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
    WriteLine("The current platform does not support changing the size of the cursor.");
}

if(OperatingSystem.IsWindowsVersionAtLeast(major: 10))
{
    WriteLine("You're running Windows 10 or higher.");
}
else if (OperatingSystem.IsWindows())
{
    WriteLine("You're running Windows, but not 10 or higher.");
}
else if (OperatingSystem.IsIOSVersionAtLeast(major: 14, minor: 5))
{
    WriteLine("You're running iOS");
}
else if (OperatingSystem.IsBrowser())
{
    WriteLine("You're using a browser, maybe.");
}
