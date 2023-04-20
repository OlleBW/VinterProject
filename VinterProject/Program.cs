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

while (Player.HP > 0 || Enemy.HP > 0)
{
    Console.WriteLine("Choose what to do this turn:");
    Console.WriteLine("1. Attack");
    Console.WriteLine("2. Defend");
    string? answer = Console.ReadLine();
    if (answer == "1")
    {
        Player.Attack();
    }
    if (answer == "2")
    {
        Player.Defend();
    }
    else { Console.Clear(); }
}