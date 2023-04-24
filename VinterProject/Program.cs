global using System;
global using System.Collections.Generic;

// Main Menu för spelet

Console.WriteLine("Fighting Game!");
Console.WriteLine("Press ENTER To Start");
Console.ReadLine(); Console.Clear();

List<string> Names = new List<string>();

Character Enemy = Character.rndmEnemy();
Character Player = Character.pickChar();

Console.WriteLine("Please name your Character");
Player.name = Console.ReadLine();
Names.Add($"{Player.name}");
Console.Clear();

Console.WriteLine("Please name your Enemy");
Enemy.name = Console.ReadLine();
Names.Add($"{Enemy.name}");
Console.Clear();



// Loop för fighting sekvensen av spelet
while (Player.HP >= 0 || Enemy.HP >= 0)
{
    Console.WriteLine($"{Names[0]} HP: {Player.HP} {Names[1]} HP: {Enemy.HP}");
    Console.WriteLine("Choose what to do this turn:");
    Console.WriteLine("1. Attack");
    Console.WriteLine("2. Guard");
    string? answer = Console.ReadLine();
    if (answer == "1")
    {
        Console.Clear();
        Console.WriteLine($"{Names[0]} HP: {Player.HP} {Names[1]} HP: {Enemy.HP}");
        Player.Attack(Enemy);
        Console.WriteLine($"You attack your opponent and deal some damage.");
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();
        if (Enemy.HP > 0)
        {
            Console.Clear();
            Console.WriteLine($"{Names[0]} HP: {Player.HP} {Names[1]} HP: {Enemy.HP}");
            Enemy.Attack(Player);
            Console.WriteLine($"Your enemy attacks you and deals some damage.");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
        }
    }
    //if (answer == "2")
    //{
    // Player.Guard();
    //}
    else { Console.Clear(); Console.WriteLine("You did not follow the instructions correctly"); }
}
if (Player.HP <= 0)
{
    ToolBox.Lost();
}
else if (Enemy.HP <= 0)
{
    ToolBox.Won();
}
else if (Player.HP <= 0 && Enemy.HP <= 0)
{
    ToolBox.Tie();
}