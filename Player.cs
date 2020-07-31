using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    abstract class Player 
    {
        public Roshambo WeaponIS { get; protected set; }
        public Roshambo FinalWeapon { get; protected set; }
        public string Name { get; protected set; }

        public static Random rand = new Random();

        public virtual Roshambo GenerateRoshambo()
        {
            int weapon = rand.Next(0, 3);
            Roshambo RoPaSc = (Roshambo)weapon;
            FinalWeapon = RoPaSc;
            return RoPaSc;
        }
    }
    class User : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            Console.Write($"\nRock, paper, or scissors? (R/P/S): ");
            string choice = Console.ReadLine().ToLower();
            if(choice == "r")
            { WeaponIS = Roshambo.ROCK;
                return Roshambo.ROCK; }
            else if (choice == "p")
            { WeaponIS = Roshambo.PAPER;
                return Roshambo.PAPER; }
            else if (choice == "s")
            {  WeaponIS = Roshambo.SCISSORS;
                return Roshambo.SCISSORS; }
            else
            { Console.WriteLine($"Sorry, {choice} is not an option. Try again.");
                return GenerateRoshambo();  }
        }  
    }

    class RockPlayer : Player
    {
        public RockPlayer() //constructor
        { Name = "TheJets"; }
        public override Roshambo GenerateRoshambo()
        {  return Roshambo.ROCK; }  
    }

    class RandoRPSPlayer : Player
    {
        public RandoRPSPlayer() //constructor
        {  Name = "TheSharks"; }
        public override Roshambo GenerateRoshambo()
        {
            int weapon = rand.Next(0, 3);
            Roshambo RoPaSc = (Roshambo)weapon;
            FinalWeapon = RoPaSc;
            return RoPaSc;
        }
    }
}
