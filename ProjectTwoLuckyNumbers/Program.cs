using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTwoLuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //delaring the string answer which will be used to determine if the loop continues past the first instance of game play.
            string answer;

            //Creating the entire game within a do while loop to ensure the user is able to decide whether or not they'd like to continue playing once they reach the end.
            do
            {
                //Getting user input to declare the bounds of the range of random numbers:
                Console.WriteLine("Welcome to the \"Lucky Numbers\" game! The jackpot is $888,888,888.888 \n Please enter a starting number for the lower bound of your range: ");
                int lowerBound = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter a number for the upper bound of your range: ");
                int upperBound = int.Parse(Console.ReadLine());
                Console.WriteLine("Try to guess the six numbers that will be chosen to win the game!");

                //Creating an array to hold the user's input
                int[] sixNumbers = new int[6];

                //Populating the array with the user's unput of 6 numbers (only valid numbers!)
                for (int i = 0; i < sixNumbers.Length; i++)
                {
                    Console.WriteLine("Please enter a number: ");
                    int input = int.Parse(Console.ReadLine());
                    if (lowerBound <= input && input <= upperBound)
                    {
                        sixNumbers[i] = input;
                    }
                    else
                    {
                        Console.WriteLine("Number invalid, please enter a valid number: ");
                    }
                }

                //Displaying the user's sesctions
                Console.WriteLine("You have chosen the following numbers: {0}, {1}, {2}, {3}, {4}, {5}.", sixNumbers[0], sixNumbers[1], sixNumbers[2], sixNumbers[3], sixNumbers[4], sixNumbers[5]);

                //Generating and displaying the 6 random "Lucky Numbers"
                Console.WriteLine("The six Lucky Numbers are: ");

                Random r = new Random();
                int[] luckyNumbers = new int[6];
                for (int i = 0; i < luckyNumbers.Length; i++)
                {
                    luckyNumbers[i] = r.Next(lowerBound, upperBound);
                    Console.WriteLine("Lucky Number: " + luckyNumbers[i]);
                }

                //Checking the number of correct guesses:
                int correct = 0;

                    for (int i = 0; i < luckyNumbers.Length; i++)
                    {
                        if (sixNumbers[0] == luckyNumbers[i])
                        {
                            correct++;
                        }
                    }
                for (int i = 0; i < luckyNumbers.Length; i++)
                {
                    if (sixNumbers[1] == luckyNumbers[i])
                    {
                        correct++;
                    }
                }
                for (int i = 0; i < luckyNumbers.Length; i++)
                {
                    if (sixNumbers[2] == luckyNumbers[i])
                    {
                        correct++;
                    }
                }
                for (int i = 0; i < luckyNumbers.Length; i++)
                {
                    if (sixNumbers[3] == luckyNumbers[i])
                    {
                        correct++;
                    }
                }
                for (int i = 0; i < luckyNumbers.Length; i++)
                {
                    if (sixNumbers[4] == luckyNumbers[i])
                    {
                        correct++;
                    }
                }
                for (int i = 0; i < luckyNumbers.Length; i++)
                {
                    if (sixNumbers[5] == luckyNumbers[i])
                    {
                        correct++;
                    }
                }

                Console.WriteLine("You guessed {0} numbers correctly!", correct);








                //The final question of the loop, the input from this will determine if the user plays again
                Console.WriteLine("Would you like to play again? Please enter \'yes\' o r\'no\'.");
                 answer = Console.ReadLine().ToLower();
            } while (answer == "yes");
            Console.WriteLine("Thanks for playing!");


        }
    }
}

