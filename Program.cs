using System;
using System.Collections.Generic;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerCount = 0;
            int compCount = 0;
            void MainTaco()
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Rock Paper Scissors!");
                Console.WriteLine("What would you like to throw?");
                Console.WriteLine("--------------------------------------------");
                string userInput = Console.ReadLine();
                RPS(userInput);
            };

            void RPS(string userInput)
            {
                while (userInput != "1" && userInput != "2" && userInput != "3")
                {
                    Console.WriteLine("Improper input please try again");
                    userInput = Console.ReadLine();
                }

                Random randInt = new Random();
                int taco = randInt.Next(1, 4);

                ShowHand(userInput);

                Console.WriteLine("VS.");

                ShowHand(taco.ToString());

                whoWon(userInput, taco.ToString());
            };

            void ShowHand(string userInput)
            {

                if (userInput == "1")
                {
                    Console.WriteLine("Rock");
                }
                else if (userInput == "2")
                {
                    Console.WriteLine("Paper");
                }
                else if (userInput == "3")
                {
                    Console.WriteLine("Scissors");
                }

            }

            void whoWon(string userInput, string compInput)
            {
                if (userInput == compInput)
                {
                    Console.WriteLine("Its a tie");
                }
                else if (userInput == "1" && compInput == "2")
                {
                    Console.WriteLine("Comp wins this round ");
                    compCount++;
                    Console.WriteLine("Player Score: " + playerCount);
                    Console.WriteLine("Computer Score: " + compCount);
                }
                else if (userInput == "1" && compInput == "3")
                {
                    Console.WriteLine("Player wins this round ");
                    playerCount++;
                    Console.WriteLine("Player Score: " + playerCount);
                    Console.WriteLine("Computer Score: " + compCount);
                }
                else if (userInput == "2" && compInput == "1")
                {
                    Console.WriteLine("Player wins this round ");
                    playerCount++;
                    Console.WriteLine("Player Score: " + playerCount);
                    Console.WriteLine("Computer Score: " + compCount);
                }
                else if (userInput == "2" && compInput == "3")
                {
                    Console.WriteLine("Comp wins this round ");
                    compCount++;
                    Console.WriteLine("Player Score: " + playerCount);
                    Console.WriteLine("Computer Score: " + compCount);
                }
                else if (userInput == "2" && compInput == "1")
                {
                    Console.WriteLine("Player wins this round ");
                    playerCount++;
                    Console.WriteLine("Player Score: " + playerCount);
                    Console.WriteLine("Computer Score: " + compCount);
                }
                else if (userInput == "2" && compInput == "3")
                {
                    Console.WriteLine("Player wins this round ");
                    compCount++;
                    Console.WriteLine("Player Score: " + playerCount);
                    Console.WriteLine("Computer Score: " + compCount);
                }
                else if (userInput == "3" && compInput == "1")
                {
                    Console.WriteLine("Comp wins this round ");
                    compCount++;
                    Console.WriteLine("Player Score: " + playerCount);
                    Console.WriteLine("Computer Score: " + compCount);
                }
                else if (userInput == "3" && compInput == "2")
                {

                    Console.WriteLine("Player wins this round ");
                    playerCount++;
                    Console.WriteLine("Player Score: " + playerCount);
                    Console.WriteLine("Computer Score: " + compCount);
                }

                if (playerCount != 3 && compCount != 3)
                {
                    MainTaco();
                }
                else
                {
                    System.Environment.Exit(0);
                }
            }

            MainTaco();
        }
    }
}
