global using System;

// Main Menu för spelet

Console.WriteLine("Fighting Game!");
Console.WriteLine("Press ENTER To Start");
Console.ReadLine(); Console.Clear();

Character Player = new Character();
Character Enemy = new Character();

// Prompt för att namnge din karaktär, samt en confirmation för namnet
ToolBox.NameConfirm(Player.name);


while (Player.HP >= 0 || Enemy.HP >= 0)
{
    // Player attacks (Creates random based of ATK)
    // Enemy loses HP

    //Enemy attacks based off ATK
    //Player loses HP
}

if (Player.HP <= 0)
{
    ToolBox.Lost();
}
if (Enemy.HP <= 0)
{
    ToolBox.Won();
}
