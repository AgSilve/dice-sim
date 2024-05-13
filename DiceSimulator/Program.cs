// This program gives a visual output when the user chooses to roll a dice.
using System;

    namespace DiceSimulator
    {
        internal class Program
        {
        static void RollDice()
            {
                Random random = new();
                int diceRoll = random.Next(1, 7);
                switch (diceRoll)
                {
                    case 1:
                        Console.WriteLine("[-----]");
                        Console.WriteLine("[     ]");
                        Console.WriteLine("[  0  ]");
                        Console.WriteLine("[     ]");
                        Console.WriteLine("[-----]");
                        Console.WriteLine("You've rolled 1!");
                        break;
                    case 2:
                        Console.WriteLine("[-----]");
                        Console.WriteLine("[  0  ]");
                        Console.WriteLine("[     ]");
                        Console.WriteLine("[  0  ]");
                        Console.WriteLine("[-----]");
                        Console.WriteLine("You've rolled 2!");
                        break;
                    case 3:
                        Console.WriteLine("[-----]");
                        Console.WriteLine("[     ]");
                        Console.WriteLine("[0 0 0]");
                        Console.WriteLine("[     ]");
                        Console.WriteLine("[-----]");
                        Console.WriteLine("You've rolled 3!");
                        break;
                    case 4:
                        Console.WriteLine("[-----]");
                        Console.WriteLine("[0   0]");
                        Console.WriteLine("[     ]");
                        Console.WriteLine("[0   0]");
                        Console.WriteLine("[-----]");
                        Console.WriteLine("You've rolled 4!");
                        break;
                    case 5:
                        Console.WriteLine("[-----]");
                        Console.WriteLine("[0   0]");
                        Console.WriteLine("[  0  ]");
                        Console.WriteLine("[0   0]");
                        Console.WriteLine("[-----]");
                        Console.WriteLine("You've rolled 5!");
                        break;
                    case 6:
                        Console.WriteLine("[-----]");
                        Console.WriteLine("[0 0 0]");
                        Console.WriteLine("[     ]");
                        Console.WriteLine("[0 0 0]");
                        Console.WriteLine("[-----]");
                        Console.WriteLine("You've rolled 6!");
                        break;
                    default:
                        Console.WriteLine("Unable to roll a dice.");
                        break;
                }
            }
        static void Main()
            {
                while (true)
                {
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("1. Roll a dice or 2. Exit");
                    string? userInput = Console.ReadLine();

                    if (userInput == "1")
                    {
                        Console.WriteLine("You have chosen to roll a dice.");
                        Console.WriteLine("Rolling...");
                        RollDice();
                    }
                    else if (userInput == "2")
                    {
                        Console.WriteLine("Exiting...");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter 1 to roll a dice or 2 to exit.");
                    }
                }
            }
    }
}
