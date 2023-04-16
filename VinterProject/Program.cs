global using System;

// Main Menu för spelet

Console.WriteLine("Fighting Game!");
Console.WriteLine("Press ENTER To Start");
Console.ReadLine(); Console.Clear();


Character Enemy = new Character();

FighterType1 Player = new FighterType1();

// Prompt för att namnge din karaktär, samt en confirmation för namnet
ToolBox.NameConfirm(Player.name);





while (Player.HP >= 0 || Enemy.HP >= 0)
{

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
