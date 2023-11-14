using System;
namespace DiceRollGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random();
            bool continuePlaying = true;
            Console.WriteLine("Welcome to the Dice Roll Game!");
            while (continuePlaying)
            {
                for (int i = 1; i <= 3; i++)
                {
                    int rollResult = dice.Next(1, 7);
                    Console.WriteLine($"Roll {i}: {rollResult}");
                }
                Console.Write("Do you want to continue playing? (y/n): ");
                string input = Console.ReadLine();
                // Check if the user wants to continue playing
                continuePlaying = input.ToLower() == "y" || input.ToLower() == "yes";
            }
            Console.WriteLine("Thank you for playing the Dice Roll Game!");
        }
    }
}

 