using System;

// Namespace
namespace Number_Guesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            GetAppInfo(); // Run fucntion to get info

            GreetUser(); // Ask for user's name and then greet' 

            while (true)

            {

                // Create new Random Object
                Random random = new Random();

                int correctNumber = random.Next(1, 11);

                // Set guess var
                int guess = 0;

                // Ask user for a number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {

                    // Get users input
                    string input = Console.ReadLine();

                    // Make sure guess is a number
                    if (!int.TryParse(input, out guess))
                    {

                        // Print Error message
                        PrintColorAndMessage(ConsoleColor.Red, "That's not a number. Please try again");


                        // Keep game going
                        continue;
                    }

                    // Cast to int and put in guess var
                    guess = Int32.Parse(input);

                    //match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print Error message
                        PrintColorAndMessage(ConsoleColor.Red, "Wrong number. Please try again");
                    }
                }

                // Output Success Message
                PrintColorAndMessage(ConsoleColor.Yellow, "Correct!!! You Guessed it");

                // Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }

            }
        }

        // Get and Display app info
        static void GetAppInfo()
        {
            // Set up Variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Melissa Heying";

            // Change text color

            Console.ForegroundColor = ConsoleColor.Magenta;

            // Write out app info
            Console.WriteLine("{0}: Version: {1}, by {2}", appName, appVersion, appAuthor);


            // Reset Text color
            Console.ResetColor();

        }

        // Ask user's name and then greet
        static void GreetUser()
        {
            // Ask user's name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            // Greet user
            Console.WriteLine("Hello {0}, Let's play a game", inputName);
        }

        // Print color and message
        static void PrintColorAndMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine(message);

            // Reset Text color
            Console.ResetColor();
        }
    }
}
