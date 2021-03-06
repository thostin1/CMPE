﻿//**************************************************************************************************************************************************
//Taylor Hostin Assignment 6
//*************************************************************************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;
using System.Threading;

namespace ICA06_GDIDrawer_cont._TaylorHostin
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareSize, numSquares, xNum, yNum; //Claim the user input of square size and the number of squares along with the x and y coordinates which will be randomized

            //create canvas window
            CDrawer Canvas = new CDrawer(800, 600);

            string userSelect; //Users selection to restart the program

            //Begin Do While loop for when the user wants to restart the program
            do
            {
                //Canvas and console clear to clear the windows when the user restarts
                Canvas.Clear();
                Console.Clear();
                
                //Display name and assignment number
                Console.WriteLine("\t\t\t\t\t\tICA06 Taylor Hostin");

                //First user input checking for an integer
                Console.Write("Enter the size if the squares: ");
                int.TryParse(Console.ReadLine(), out squareSize);

                //Create a while loop preventing a letter or an invalid square sixe to be input
                while (squareSize < 10 || squareSize > 200)
                {
                    //Clear the console window if invalid input is input along with an error message 
                    Console.Clear();
                    Console.Write("Error: Enter the size of the squares (10-200): ");
                    int.TryParse(Console.ReadLine(), out squareSize);
                }

                //display user input for number of squares again checking for an invalid integer such as character(s) or negative or 0 values
                Console.Write("Enter the number of squares to display: ");
                int.TryParse(Console.ReadLine(), out numSquares);

                //Create another while loop to check for valid input
                while (numSquares <= 0)
                {
                    //Display error message along with an option for the user to input a valid amount of squares
                    Console.Write("Error: Enter the number of squares to display(Greater than 0): ");
                    int.TryParse(Console.ReadLine(), out numSquares);
                }


                //Begin the square count at 0 and create a random command for the x and y locations
                int count = 0;
                Random randomNumber = new Random();

                //This while loop will loop until the number of squares input by the user is matched and the proper amount of squares are displayed
                while (count <= numSquares)
                {
                    //The user input will be stuck in this loop until the amount is matched by adding one to the square count each loop
                    count = count + 1; 
                    
                    //The random number generator will pick x and y coordinates within the window size
                    yNum = randomNumber.Next(0, 601);
                    xNum = randomNumber.Next(0, 801);

                    //Conditional operator to keep the x coordiante from putting the squares outside the window
                    xNum = (xNum > (800 - (squareSize))) ? (800 - (squareSize)) : xNum;


                    //Conditional operator to keep the y coordinate from putting the squares outside the window
                    yNum = (yNum > (600 - (squareSize))) ? (600 - (squareSize)) : yNum;

                    //The command to put the rectangle in the GDI drawer with users size, random coordinates, and random colors
                    Canvas.AddRectangle(xNum, yNum, squareSize, squareSize, RandColor.GetColor());

                }
                
                //Display input for the user to run the program again
                Console.Write("Runprogram again? (y/n):");
                userSelect = Console.ReadLine();

                //The while portion connected to the do at the beggining so if the user inputs a lowercase or uppercase y and presses enter the program will repeat
            } while (userSelect == "y" || userSelect == "Y");

            //Press any key to exit command for if the user does not enter y or Y
            Console.WriteLine("\nPress any key to exit: ");
            Console.ReadKey();

        }
    }
}
