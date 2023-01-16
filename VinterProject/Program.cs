global using System;

// Main Menu för spelet
ToolBox.WriteCentered("Fighting Game!");
ToolBox.WriteCentered("Press ENTER To Start");
Console.ReadLine(); Console.Clear();

Character Player = new Character();
Character Enemy = new Character();

// Prompt för att namnge din karaktär, samt en confirmation för namnet
ToolBox.NameConfirm(Player.name);

Console.WriteLine($"{Player.name}");

//Console.WriteLine($"{Player.name}");

while (Player.HP <= 0 || Enemy.HP <= 0)
{

}



Console.WriteLine("Game Over");
Console.ReadLine();