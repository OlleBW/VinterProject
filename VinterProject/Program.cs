global using System;

// Main Menu för spelet

Console.WriteLine("Fighting Game!");
Console.WriteLine("Press ENTER To Start");
Console.ReadLine(); Console.Clear();

List<string> Names = new List<string>(){};

Character Enemy = Character.rndmEnemy();
Character Player = Character.pickChar();

Console.WriteLine("Please name your Character");
Player.name = Console.ReadLine();
Names.add($"{Player.name}");
Console.Clear();

Console.WriteLine("Please name your Enemy");
Enemy.name = Console.ReadLine();
Names.add($"{Enemy.name}");
Console.Clear();



// Loop för fighting sekvensen av spelet
while (Player.HP >= 0 || Enemy.HP >= 0)
{
    Console.WriteLine($"{Player.name} HP: {Player.HP} Enemy HP: {Enemy.HP}");
    Console.WriteLine("Choose what to do this turn:");
    Console.WriteLine("1. Attack");
    Console.WriteLine("2. Guard");
    string? answer = Console.ReadLine();
    if (answer == "1")
    {
        Console.Clear();
        Console.WriteLine($"{Player.name} HP: {Player.HP} Enemy HP: {Enemy.HP}");
        Player.Attack(Enemy);
        Console.WriteLine($"You attack your opponent and deal some damage.");
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();
        if (Enemy.HP > 0)
        {
            Console.Clear();
            Console.WriteLine($"{Player.name} HP: {Player.HP} Enemy HP: {Enemy.HP}");
            Enemy.Attack(Player);
            Console.WriteLine($"Your enemy attacks you and deals some damage.");
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
        }
    }
    if (answer == "2")
    {
        Console.Clear();
        Console.WriteLine($"{Player.name} HP: {Player.HP} Enemy HP: {Enemy.HP}");
        Console.WriteLine("This Skill is a work in progress!");
        Player.Attack(Enemy);
        Console.WriteLine("You Attack your opponent instead");
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

    }
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