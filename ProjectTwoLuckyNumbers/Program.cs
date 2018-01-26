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
            Start;
            Console.WriteLine("Welcome to the \"Lucky Numbers\" game! The jackpot is $888,888,888.888 \n Please enter a starting number for the lower bound of your range: ");
            int lowerBound = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number for the upper bound of your range: ");
            int upperBound = int.Parse(Console.ReadLine());
            Console.WriteLine("Try to guess the six numbers that will be chosen to win the game!");
            int[] sixNumbers = new int[6];
            for (int i = 0; i < sixNumbers.Length; i++)
            {
                Console.WriteLine("Please enter a number: ");
                sixNumbers[i] = int.Parse(Console.ReadLine());
                if(sixNumbers[i] > upperBound || sixNumbers[i] < lowerBound)
                {
                    Console.WriteLine("Number invalid, please enter a valid number: ");
                }
            }
            Console.WriteLine("The six Lucky Numbers are: ");

            Random r = new Random();
            int[] luckyNumbers = new int[6];
            for(int i = 0; i < luckyNumbers.Length; i++)
            {
                luckyNumbers[i] = r.Next(lowerBound, upperBound);
                Console.WriteLine("Lucky Number: " + luckyNumbers[i]);
            }

            End;
        }
    }
}

