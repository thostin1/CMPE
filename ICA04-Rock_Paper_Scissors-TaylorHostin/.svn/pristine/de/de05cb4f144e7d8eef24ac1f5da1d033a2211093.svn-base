//**************************************************************************************************************************************************************
//Taylor Hostin Assignment 4
//**************************************************************************************************************************************************************
using System;
using System.Runtime.CompilerServices;

namespace ICA04_Rock_Paper_Scissors_TaylorHostin
{
    class Program
    {
        static void Main(string[] args)
        {

            string userSelection; //users choice 
            int randomNumber; //claim the computer generated inteher which will decide which choice of play the computer chooses
            Random generator = new Random(); // Random number generator

            //Display name along with instructions for the user and the input line for rock paper or scissors
            Console.WriteLine("\t\t\t\t\t\tTaylor Hostin Assigment 4");
            Console.WriteLine("\nPlease select your play from the following choices...");
            Console.WriteLine("\n Paper\n Rock\n Scissors");
            Console.Write("\nYour selection: ");
            
            //Make a ToLower command so regardless of what case the user inputs the letters it will read it and output it as lowercase
            userSelection = Console.ReadLine().ToLower();

            //Command computer to pick a number 1 or higher but less than 4
            randomNumber = generator.Next(1,4);
            
            //Begin nested switch statement with each case number of the computers selection along with every outcome
            //From here i basically re-did different outcomes for each possible situation.
            //include default cases just incase the user inputs a wrong value outside of rock paper or scissors, include an error message.
            switch (randomNumber)
            {
                case 1:// Computer plays rock
                    switch (userSelection)
                    {
                        case "rock":
                            Console.WriteLine("\nComputer played rock and you played rock.");
                            Console.WriteLine("\nRock, rock draw");
                            break;
                        case "paper":
                            Console.WriteLine("\nComputer played rock and you played paper.");
                            Console.WriteLine("\nPaper covers rock, you win!");
                            break;
                        case "scissors":
                            Console.WriteLine("\nComputer played rock and you played scissors.");
                            Console.WriteLine("\nrock crushes scissors, you lose.");
                            break;
                        default:
                            Console.WriteLine("Error invalid selection.");//Error message for invalid input
                            break;

                    }
                    break;
                case 2://Computer plays paper
                    switch (userSelection)
                    {
                        case "rock":
                            Console.WriteLine("\nComputer played paper and you played rock.");
                            Console.WriteLine("\nPaper covers rock, you lose.");
                            break;
                        case "paper":
                            Console.WriteLine("\nComputer played paper and you played paper.");
                            Console.WriteLine("\nPaper, paper draw");
                            break;
                        case "scissors":
                            Console.WriteLine("\nComputer played paper and you played scissors.");
                            Console.WriteLine("\nScissors cut paper, you win!");
                            break;
                        default:
                            Console.WriteLine("Error invalid selection.");
                            break;
                    }
                    break;
                case 3://Computer plays scissors
                    switch (userSelection)
                    {
                        case "rock":
                            Console.WriteLine("\nComputer played scissors and you played rock.");
                            Console.WriteLine("\nRock crushes scissors, you win!");
                            break;
                        case "paper":
                            Console.WriteLine("\nComputer played scissors and you played paper.");
                            Console.WriteLine("\nScissors cuts paper, you lose");
                            break;
                        case "scissors":
                            Console.WriteLine("\nComputer played scissors and you played scissors.");
                            Console.WriteLine("\nScissors, scissors, Draw");
                            break;
                        default:
                            Console.WriteLine("Error invalid selection.");
                            break;
                    }
                    break;
            }   //Did not create a default statement for the mother switch because the computer wont generate a case number outside of 1 and 3
            
            Console.WriteLine("\nPress any key to exit:");
            Console.ReadKey();
            // Pause program for user to read and allow press any key to exit 






        }

    }
}
