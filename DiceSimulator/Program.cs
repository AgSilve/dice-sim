// This program gives a visual output when the user chooses to roll a dice.
Random random = new();

 while (true)
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1. Roll a dice or 2. Exit");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("You have chosen to roll a dice.");
                // Code for rolling the dice to be added here
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