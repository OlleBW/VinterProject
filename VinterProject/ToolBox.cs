using System;
public class ToolBox
{
    public static void WriteCentered(string text)
    {
        int numberOfSpaces = Console.WindowWidth / 2 - text.Length / 2;

        int i = 0;
        while (i < numberOfSpaces)
        {
            i++;
            Console.Write(" ");
        }
        Console.WriteLine(text);
    }
    public static void WriteEnd(string text)
    {
        int numberOfSpaces = Console.WindowWidth - text.Length * 6;

        int i = 0;
        while (i < numberOfSpaces)
        {
            i++;
            Console.Write(" ");
        }
        Console.WriteLine(text);
    }
    public static void WriteBeginning(string text)
    {
        int numberOfSpaces = Console.WindowWidth + text.Length * 6;

        int i = 0;
        while (i < numberOfSpaces)
        {
            i++;
            Console.Write(" ");
        }
        Console.WriteLine(text);
    }
}