global using System;

// Main Menu för spelet

Console.WriteLine("Fighting Game!");
Console.WriteLine("Press ENTER To Start");
Console.ReadLine(); Console.Clear();

Character Enemy = Character.rndmEnemy();
Character Player = Character.pickChar();
Character.setName();

