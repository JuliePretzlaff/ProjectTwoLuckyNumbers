﻿using System;
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
                Console.WriteLine("Welcome to the \"Lucky Numbers\" game! \n The jackpot is $900,000 \n Please enter a starting number for the lower bound of your range: ");
                int lowerBound = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter an ending number for the upper bound of your range: ");
                int upperBound = int.Parse(Console.ReadLine());
                Console.WriteLine("Try to guess the six numbers that will be chosen to win the game!");


                //Creating an array to hold the user's input
                int[] sixNumbers = new int[6];


                //Populating the array with the user's input of 6 numbers (only valid numbers!)
                for (int i = 0; i < sixNumbers.Length; i++)
                {
                    Console.WriteLine("Please enter a number: ");
                    sixNumbers[i] = int.Parse(Console.ReadLine());
                    while (upperBound < sixNumbers[i] || sixNumbers[i] < lowerBound)
                    {
                        Console.WriteLine("Number invalid, please enter a valid number: ");
                        sixNumbers[i] = int.Parse(Console.ReadLine());
                    }
                }


                //Displaying the user's selections
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


                ////attempting stretch work:
                //for (int i = 0; i < luckyNumbers.Length; i++)
                //{
                //    for (int j = 0; j < i; j++)
                //    {
                //        do
                //        {
                //            luckyNumbers[i] = r.Next(lowerBound, upperBound);
                //        } while (luckyNumbers[i] == luckyNumbers[j]);
                //    }
                //}


                //Checking the number of correct guesses:
                double correct = 0;

                for (int i = 0; i < sixNumbers.Length; i++)
                {
                    for (int j = 0; j < luckyNumbers.Length; j++)
                    {
                        if (sixNumbers[i] == luckyNumbers[j])
                        {
                            correct++;
                        }
                    }
                }
               
                Console.WriteLine("You guessed {0} numbers correctly!", correct);
                

                //Arthimetic to determine the amount of money user has won:
                double winnings = (900000 * (correct/6));
                Console.WriteLine("You won $" + winnings + "!");


                //The final question of the loop, the input from this will determine if the user plays again
                Console.WriteLine("Would you like to play again? Please enter \'yes\' or \'no\'.");
                 answer = Console.ReadLine().ToLower();
            } while (answer == "yes");
            Console.WriteLine("Thanks for playing!");

        }
    }
}

 