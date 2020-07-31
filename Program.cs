using System;

namespace Roshambo
{

    class Program
    {

        static void Main(string[] args)
        {
            bool keepLooping = true;
            string challenger = "none";
            string anotherRound;

            Player user = new User();
            Player opponent;
            
            Console.WriteLine("Welcome to Rock Paper Scissors!\n");
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            do
            {
                Console.Write($"\nWould you like to play against TheJets or TheSharks (j/s)?: ");
                challenger = Console.ReadLine().ToLower();

                if (challenger == "j")
                {  opponent = new RockPlayer(); }
                else
                { opponent = new RandoRPSPlayer(); }
            } while (challenger != "j" && challenger != "s");

            while (keepLooping)
            {
                user.GenerateRoshambo();
                opponent.GenerateRoshambo();

                Console.WriteLine($"\n{userName}: {user.WeaponIS}");
                Console.WriteLine($"{opponent.Name}: {opponent.FinalWeapon}");

                if (user.WeaponIS == Roshambo.ROCK && opponent.FinalWeapon == Roshambo.ROCK)
                {
                    Console.WriteLine("Draw!");
                }
                else if (user.WeaponIS == Roshambo.ROCK && opponent.FinalWeapon == Roshambo.PAPER)
                {
                    Console.WriteLine($"{opponent.Name} wins!");
                }
                else if (user.WeaponIS == Roshambo.ROCK && opponent.FinalWeapon == Roshambo.SCISSORS)
                {
                    Console.WriteLine($"{userName} wins!");
                }
                else if (user.WeaponIS == Roshambo.PAPER && opponent.FinalWeapon == Roshambo.ROCK)
                {
                    Console.WriteLine($"{userName} wins!");
                }
                else if (user.WeaponIS == Roshambo.PAPER && opponent.FinalWeapon == Roshambo.PAPER)
                {
                    Console.WriteLine($"Draw!");
                }
                else if (user.WeaponIS == Roshambo.PAPER && opponent.FinalWeapon == Roshambo.SCISSORS)
                {
                    Console.WriteLine($"{opponent.Name} wins!");
                }
                else if (user.WeaponIS == Roshambo.SCISSORS && opponent.FinalWeapon == Roshambo.ROCK)
                {
                    Console.WriteLine($"{opponent.Name} wins!");
                }
                else if (user.WeaponIS == Roshambo.SCISSORS && opponent.FinalWeapon == Roshambo.PAPER)
                {
                    Console.WriteLine($"{userName} wins!");
                }
                else if (user.WeaponIS == Roshambo.SCISSORS && opponent.FinalWeapon == Roshambo.SCISSORS)
                {
                    Console.WriteLine($"Draw!");
                }
                    do
                {
                    Console.Write($"\nPlay again? (y/n): ");
                    anotherRound = Console.ReadLine().ToLower();
                    if (anotherRound == "n")
                    { keepLooping = false; }
                    else if (anotherRound == "y")
                    { continue; }
                    else
                    {
                        Console.WriteLine("That is not a valid choice. Select y or n ");
                    }
                } while (anotherRound != "y" && anotherRound != "n");
            }
        }
    }
}
