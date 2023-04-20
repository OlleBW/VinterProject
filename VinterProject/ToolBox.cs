using System;
public class ToolBox
{
    public static void Lost()
    {
        Console.WriteLine("You Lost! blablabla");
        Console.WriteLine("Press ENTER to EXIT");
        Console.ReadLine();
    }
    public static void Won()
    {
        Console.WriteLine("You Won! blablabla");
        Console.WriteLine("Press ENTER to EXIT");
        Console.ReadLine();
    }
    public static void Tie()
    {
        Console.WriteLine("It's a Tie! blablabla");
        Console.WriteLine("Press ENTER to EXIT");
        Console.ReadLine();
    }
}