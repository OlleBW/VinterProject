global using System;

Character Player = new Character();

ToolBox.WriteCentered("Fighting Game!");
ToolBox.WriteCentered("Press ENTER To Start");
Console.ReadLine(); Console.Clear();

ToolBox.WriteCentered("Please Name your fighter and press ENTER");
Player.name = Console.ReadLine();
Console.Clear();
NameConfirm();


ToolBox.WriteBeginning("");
ToolBox.WriteEnd("");
Console.ReadLine();


while (true)
{
}







void NameConfirm()
{
    ToolBox.WriteCentered($"Do you want to be named {Player.name}");
    Console.ReadLine();
}