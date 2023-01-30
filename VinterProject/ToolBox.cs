using System;
public class ToolBox
{
    public static void NameConfirm(string name)
    {
        bool confirmed = false;
        bool invalidAnswer = false;

        // Loop som ser till att ett namn blir satt (svarar du nej på confirmation kommer du tillbaka hit)
        while (confirmed == false)
        {
            Console.WriteLine("Please Name your fighter and press ENTER");
            name = Console.ReadLine();
            Console.Clear();
            invalidAnswer = false;

            // Ser till att confirmation svaras och inte skippas
            while (invalidAnswer == false)
            {
                Console.WriteLine($"Do you want to be named {name}");
                Console.WriteLine("1. YES     2. NO");
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
    public static void Lost()
    {
        Console.WriteLine("You Lost! blablabla");
    }
    public static void Won()
    {
        Console.WriteLine("You Won! blablabla");
    }
}