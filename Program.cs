using System;
using System.IO;

namespace DiceRoller
{
    class Dice
    {
        private Random random;

        public Dice()
        {
            random = new Random();
        }

        public int Roll()
        {
            return random.Next(1, 7);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dice Roller!");

            Console.Write("Enter the number of dice to roll (1-6): ");
            int numDice = Convert.ToInt32(Console.ReadLine());

            // Validate input
            if (numDice < 1 || numDice > 6)
            {
                Console.WriteLine("Invalid number of dice. Please enter a number between 1 and 6.");
                return;
            }

            Dice[] dices = new Dice[numDice];

            // Initialize dice objects
            for (int i = 0; i < numDice; i++)
            {
                dices[i] = new Dice();
            }

            Console.WriteLine("Rolling the dice...");

            // Roll each dice and display the result
            for (int i = 0; i < numDice; i++)
            {
                Console.WriteLine($"Dice {i + 1}: {dices[i].Roll()}");
            }

            // Save the dice rolls to a CSV file
            string filePath = "dice_rolls.csv";
            SaveToCSV(filePath, dices);

            Console.WriteLine($"Dice rolls saved to {filePath}");
        }

        static void SaveToCSV(string filePath, Dice[] dices)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Dice Number, Roll Result");

                for (int i = 0; i < dices.Length; i++)
                {
                    writer.WriteLine($"{i + 1}, {dices[i].Roll()}");
                }
            }
        }
    }
}
