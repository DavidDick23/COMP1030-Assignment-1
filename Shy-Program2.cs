/*Shy-Anna Lee, David Dick, Mark Fisher, Suganth Vijayavel
 
Part 1 – USER MODE (Visual Studio / C#)
Goal: You (the user) guess the number the computer randomly generates.
Requirements:
- Use Random class to generate a secret number between 1–100.
- Ask the user to guess until correct.
- Give hints like “Too high!” or “Too low!”.
- Use if, else, while, and functions.
- Display the number of attempts taken.
 */

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Group11_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarations of variables
            int low = 1;
            int high = 100;
            int maxAttempts = 7;
            int attempts = 0;

            //- Use Random class to generate a secret number between 1–100.
            Random rand = new Random();
            int targetNumber = rand.Next(low, high + 1);

            Console.WriteLine("Welcome to the Numbers Guessing Game!");
            Console.WriteLine($"Try to guess the correct number I'm thinking of between {low} and {high}.");//- Ask the user to guess until correct.
            Console.WriteLine($"You have a maximum of {maxAttempts} attempts. Best of luck!");



            //GUESSING GAME LOOP
            while (attempts < maxAttempts)
            {
                Console.Write($"Attempt {attempts + 1}: Enter your guess: ");//- Display the number of attempts taken.
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int playerGuess))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                    continue;//Skip incrementing if invalid input
                }

                attempts++;


                //compare guess for hints 
                //- Give hints like “Too high!” or “Too low!”.
                //- Use if, else, while, and functions.
                if (playerGuess < targetNumber)
                {
                    Console.WriteLine("Too Low!");
                }

                else if (playerGuess > targetNumber)
                {
                    Console.WriteLine(" Too High!");
                }
                else
                {
                    Console.WriteLine($"Correct! You guessed the right number!");
                    break;
                }

                //MAX ATTEMPTS
               // Console.WriteLine($"You are out guesses! The number was {targetNumber}.");



               }

            }
        }
    }

