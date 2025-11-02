using System;

class Program
{
    static void Main()
    {
        string playAgain;

        do
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            int guess = 0;
            int attempts = 0;

            Console.WriteLine("Guess My Number Game!");
            Console.WriteLine("I have picked a number between 1 and 100.");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {attempts} tries!");
                }
            }

            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}
