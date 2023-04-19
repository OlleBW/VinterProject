global using System;

// Main Menu för spelet

Console.WriteLine("Fighting Game!");
Console.WriteLine("Press ENTER To Start");
Console.ReadLine(); Console.Clear();

Character Enemy = Character.rndmEnemy();
Character Player = Character.pickChar();

Console.WriteLine("Please name your character");
Player.name = Console.ReadLine();

while (Player.HP > 0 || Enemy.HP > 0)
{
    Player.Attack();
}