using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiceGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            int rolledNumber=0 ;
            string rollOrHold;
            int turnScore=0;
            int totalScore = 0;
            int turn=1;



            Console.WriteLine("Let's play PIG!");
            Console.WriteLine("* See how many turns it takes you to get to 20.");
            Console.WriteLine("* Turn ends when you hold or roll a 1.");
            Console.WriteLine("* If you roll a 1, you lose all points for the turn.");
            Console.WriteLine("*  If you hold, you save all points for the turn.");
            Console.WriteLine("\n TURN: " +turn);
            Console.WriteLine("\n Welcome to the game of Pig!");

            while (true)
            {
                Console.WriteLine("\nEnter r to roll again and h to hold:");
                rollOrHold = Console.ReadLine();
                if (rollOrHold == "r")
                {



                    rolledNumber = rnd.Next(1, 7);
                    Console.WriteLine("You rolled: " + rolledNumber);
                    if (rolledNumber == 1)
                    {
                        Console.WriteLine("Turn over. No score.");
                        turnScore = 0;
                        turn++;


                        Console.WriteLine("TURN: " + turn);
                        Console.WriteLine("-------------------");
                    }
                    else
                    {


                        turnScore += rolledNumber;
                        Console.WriteLine("Your turn score is " + turnScore + " and your total score is " + totalScore + " . ");
                        if ((turnScore+totalScore) < 20)
                        {

                            Console.WriteLine("If you hold you will have " + (turnScore + totalScore) + " points.");
                        }
                    }
                }
                else if (rollOrHold == "h")
                {

                    totalScore = turnScore;
                    Console.WriteLine("Your turn score is " + turnScore + " and your total score is " + totalScore);

                    turnScore = 0;
                    turn++;


                    Console.WriteLine("Turn " + turn);
                    Console.WriteLine("-------------------");
                }
                 if ((turnScore + totalScore) >= 20)
                {


                    Console.WriteLine("You Win!. You finished in " + turn + " turns.");
                    Console.WriteLine("\n Game Over!");
                    Environment.Exit(0);
                }
            }



        }


    }
}










