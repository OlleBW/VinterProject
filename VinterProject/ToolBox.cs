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
    public static void WriteBeginning(string text)
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
    public static void WriteEnd(string text)
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
    public static void NameConfirm()
    {
        bool confirmed = false;
        bool invalidAnswer = false;

        // Loop som ser till att ett namn blir satt (svarar du nej på confirmation kommer du tillbaka hit)
        while (confirmed == false)
        {
            ToolBox.WriteCentered("Please Name your fighter and press ENTER");
            string name = Console.ReadLine();
            Console.Clear();
            invalidAnswer = false;

            // Ser till att confirmation svaras och inte skippas
            while (invalidAnswer == false)
            {
                ToolBox.WriteCentered($"Do you want to be named {name}");
                ToolBox.WriteCentered("1. YES     2. NO");
                string answer = Console.ReadLine();
                if (answer == "1")
                {
                    invalidAnswer = true;
                    confirmed = true;
                    Console.Clear();
                }
                if (answer == "2")
                {
                    invalidAnswer = true;
                    confirmed = false;
                    Console.Clear();
                }
                else { Console.Clear(); }
            }
        }
    }
    public static void PickFighter()
    {
        bool invalidAnswer = false;
        while (invalidAnswer == false)
        {
            ToolBox.WriteCentered("Please pick your fighter with 1 or 2");
            ToolBox.WriteBeginning("Fighter1 HP : 100");
            ToolBox.WriteBeginning("Fighter1 ATK : 50");
            Console.WriteLine();
            ToolBox.WriteBeginning("Fighter2 HP : 200");
            ToolBox.WriteBeginning("Fighter2 ATK : 10");

            string answer = Console.ReadLine();
            Console.Clear();

            if (answer == "1")
            {
                Fighter1 Player = new Fighter1();
                Fighter2 Enemy = new Fighter2();
                invalidAnswer = true;
            }
            if (answer == "2")
            {
                Fighter2 Player = new Fighter2();
                Fighter1 Enemy = new Fighter1();
                invalidAnswer = true;
            }
        }
    }
}