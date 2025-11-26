using System;
class Program
{
    static void Main()
    {
        string title = "Witam w grze ???";
        int consoleWidth = Console.WindowWidth;
        int leftPadding = (consoleWidth - title.Length) / 2;

        Console.WriteLine(@"------------------------------------------------------------------------------------------");
        Console.WriteLine(title.PadLeft(leftPadding + title.Length));
        Console.WriteLine(@"------------------------------------------------------------------------------------------");
    }
}