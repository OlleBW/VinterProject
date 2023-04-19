public class Character
{
    public string? name;
    public int ATK;
    public int HP;

    public static Character rndmEnemy()
    {
        Random generator = new Random();
        int n = generator.Next(2);
        if (n == 0)
        {
            Berserk Enemy = new Berserk();
            return Enemy;
        }
        if (n == 1)
        {
            Tank Enemy = new Tank();
            return Enemy;
        }
        else
        {
            Console.WriteLine("error stupid");
        }
        return new Character();
    }
    public static Character pickChar()
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

                return Player;
            }
            if (answer == "2")
            {
                ValidAnswer = true;
                Berserk Player = new Berserk();

                return Player;
            }
            else
            {
                Console.Clear();
            }
        }
        return new Character();
    }
    public void Attack()
    {

    }
}