global using System;

// Main Menu för spelet

Console.WriteLine("Fighting Game!");
Console.WriteLine("Press ENTER To Start");
Console.ReadLine(); Console.Clear();

Character Enemy = Character.rndmEnemy();
Character Player = Character.pickChar();

Console.WriteLine("Please name your character");
Player.name = Console.ReadLine();
Console.Clear();

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
        else
        {
            Player.HP = 100;
            Enemy.HP = 0;
        }
    }
    if (answer == "2")
    {

    }
    else { Console.Clear(); }
}
if (Player.HP <= 0)
{
    Enemy.HP = 100;
    ToolBox.Lost();
}
else if (Enemy.HP <= 0)
{
    Player.HP = 100;
    ToolBox.Won();
}
else if (Player.HP <= 0 && Enemy.HP <= 0)
{
    ToolBox.Tie();
}