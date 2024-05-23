using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Battle of the Mages!");

        Console.WriteLine("Choose a mage for the first player:");
        Mage player1 = ChooseMage();

        Console.WriteLine("Choose a mage for the second player:");
        Mage player2 = ChooseMage();

        while (player1.IsAlive() && player2.IsAlive())
        {
            player1.Attack(player2);
            if (!player2.IsAlive())
            {
                Console.WriteLine($"{player2.Name} was defeated! {player1.Name} wins!");
                break;
            }

            player2.Attack(player1);
            if (!player1.IsAlive())
            {
                Console.WriteLine($"{player1.Name} was defeated! {player2.Name} wins!");
                break;
            }
        }
    }

    static Mage ChooseMage()
    {
        Console.WriteLine("1. Fire Mage");
        Console.WriteLine("2. Water Mage");
        Console.WriteLine("3. Banana Mage");
        Console.Write("Your choice: ");
        int choice = int.Parse(Console.ReadLine()!);

        Console.Write("Enter your character's name: ");
        string name = Console.ReadLine()!;

        switch (choice)
        {
            case 1:
                return new FireMage(name, 1);
            case 2:
                return new WaterMage(name, 1);
            case 3:
                return new BananaMage(name, 1);
            default:
                Console.WriteLine("Wrong choice, Fire Mage is chosen by default.");
                return new FireMage(name, 1);
        }
    }
}
