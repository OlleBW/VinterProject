global using System;

// Main Menu för spelet

Console.WriteLine("Fighting Game!");
Console.WriteLine("Press ENTER To Start");
Console.ReadLine(); Console.Clear();

bool ValidAnswer = false;
while (ValidAnswer == false)
{
    Console.WriteLine("Please pick your fightertype");
    Console.WriteLine("1. Tank: 100 HP 25 ATK");
    Console.WriteLine("2. Berserk: 25 HP 75 ATK");
    string answer = Console.ReadLine();
    if (answer == "1")
    {
        Tank Player = new Tank();
        ValidAnswer = true;
    }
    if (answer == "2")
    {
        Berserk Player = new Berserk();
        ValidAnswer = true;
    }
    else
    {
        Console.Clear();
    }
}

while(true)
{
    
}