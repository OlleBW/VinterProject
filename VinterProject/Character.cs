public class Character
{
    public string? name;
    public int ATK;
    public int HP;

    public static void pickChar()
    {
        bool ValidAnswer = false;
        while (ValidAnswer == false)
        {
            Console.WriteLine("Please pick your fightertype");
            Console.WriteLine("1. Tank: 75 HP  25 ATK");
            Console.WriteLine("2. Berserk: 25 HP  75 ATK");
            string? answer = Console.ReadLine();
            if (answer == "1")
            {
                ValidAnswer = true;
                Tank Player = new Tank();
            }
            if (answer == "2")
            {
                ValidAnswer = true;
                Berserk Player = new Berserk();
            }
            else
            {
                Console.Clear();
            }
        }
    }
    public static void setName()
    {
        Console.WriteLine("Please name your character");
        string? name = Console.ReadLine();
    }
}