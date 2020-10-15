﻿//******************************************************************************************************************
// Taylor Hostin Assignment 8
//******************************************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ICA08_ForLoops_TaylorHostin
{
    class Program
    {
        static void Main(string[] args)
        {

            string userSelect; // Users selection to re run program
            string shapeType;  // The type of shape the user wants to display
            int shapeSize;     // The size of shape the user wants to display

            //Begin full do while for if the user wants to rerun the program
            do
            {

                //Clear the console window
                Console.Clear();

                //Display name
                Console.WriteLine("\t\t\t\t\t\tICA08 Taylor Hostin");

                //Display first user input line
                Console.Write("\nEnter the shape size: ");
                int.TryParse(Console.ReadLine(), out shapeSize);

                //First do while statement creating a loop if the user inputs an invalid size
                do
                {
                    //Check for if the user inputs a string and display error message usinf if else
                    if (shapeSize == 0)
                    {
                        
                        Console.WriteLine("You have entered an invalid number.");
                        Console.Write("Enter the shape size as a whole number: ");
                        int.TryParse(Console.ReadLine(), out shapeSize);
                    }

                    //check if the user inputs above 25 using else if
                    else if (shapeSize > 25)
                    {
                        Console.WriteLine("The shape size is too big.");
                        Console.Write("Enter the shape size: ");
                        int.TryParse(Console.ReadLine(), out shapeSize);
                    }

                    //check if user inputs below 5 using else if
                    else if (shapeSize < 5)
                    {
                        Console.WriteLine("The shape size is too small.");
                        Console.Write("Enter the shape size: ");
                        int.TryParse(Console.ReadLine(), out shapeSize);
                    }

                  //While statement for all the conditions
                } while ((shapeSize == 0 || shapeSize > 25 || shapeSize < 5));

                //Display user input line for the desired shape using ToLower to convert input to lowercase
                Console.Write("Enter the desired shape: 'line', 'square', or 'triangle': ");
                shapeType = Console.ReadLine().ToLower();

                //loop for invalid input of shape type
                while (shapeType != "line" && shapeType != "square" && shapeType != "triangle")
                {
                    Console.WriteLine("You have entered an invalid shape.");
                    Console.Write("Enter the desired shape: 'line', 'square', or 'triangle': ");
                    shapeType = Console.ReadLine().ToLower();
                }

                //Switch statement to read what the user inputs for the tpe of shape and for statements within to draw them
                switch (shapeType)
                {
                    //Code to draw line
                    case "line":
                        Console.WriteLine("");
                        String numberList = "";
                        for (int i = 0; i <= 100; i++)
                        {
                            numberList += i + " ";
                        }
                        Console.WriteLine(numberList);
                
                //for statement to repeat the loop until count = shapeSize
                for (int count = 0; count <= shapeSize; count++)
                        {
                            //Multiples the space by count and repeats it in each new line to create the 'line' 
                            Console.Write(new string(' ', count));
                            Console.WriteLine("*");

                        }

                        break;

                    //Code to draw square
                    case "square":
                        Console.WriteLine("");
                        
                        //for statement to reapeat the loop until count = shapeSize
                        for (int count = 0; count <= shapeSize; count++)
                        {
                            //Multiplies the * by the shapeSize to create a square
                            Console.WriteLine(new string('*', shapeSize));
                           

                        }

                        break;
                   
                    //Code to draw triangle
                    case "triangle":
                        Console.WriteLine("");
                        
                        //for statement to repeat the loop until count = shape size
                        for (int count = 0; count <= shapeSize; count++)
                        {
                            //Multiplies the * until the count = shape size
                            Console.Write(new string('*', count));
                            Console.WriteLine("*");

                        }
                        break;
                  
                }

                //Display option for user to run the program again
                Console.WriteLine("\nRun the program again? (y/n): ");
                userSelect = Console.ReadLine();
           
            //While loop to catch users selection
            } while (userSelect == "y" || userSelect == "Y");
        }
    }
}