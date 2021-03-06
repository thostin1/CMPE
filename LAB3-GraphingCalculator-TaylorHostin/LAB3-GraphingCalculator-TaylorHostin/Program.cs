﻿//***********************************************************************************************************
// Taylor Hostin Lab 3
//***********************************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace LAB3_GraphingCalculator_TaylorHostin
{
    class Program
    {
        static void Main(string[] args)
        {
                bool bExit = false; //option to run program again

            do
            {

                Console.Clear();
                

                double a;           // a value
                double b;           // b value
                double c;           // c value
                double rootOne;     // calculated root
                int lower;          // lower limit selected
                int upper;          // upper limit selected
               

                Console.WriteLine("Quadratic Equation Graph");

                GetCoefficients(out a, out b, out c);

                GetRange(out lower, out upper);

                rootOne = Quadratic(ref a, ref b, ref c);

                DrawGraph(ref lower, ref upper, ref a, ref b, ref c, ref rootOne);

            } while ((YesNo("\nRun again? yes or no: ") == "yes") && !bExit);
        }

        //********************************************************************************************
        //Method: static private int GetValue(string prompt)
        //Purpose: Inputs an integer value with error and range checking
        //Parameters:string prompt - prompt to display to the user
        //Returns: int - value accepted by the method
        //*********************************************************************************************
        static private double GetValue(string prompt)
        {
            double value; //size from user

            //display prompt
            Console.Write($"\n{prompt}");

            //while statement checking for valid range and valid int
            while (!double.TryParse(Console.ReadLine(), out value))
            {
                
                    Console.WriteLine("Please input a number");
                    Console.Write($"\n{prompt}");
            }

            return value;

        }

        //********************************************************************************************
        //Method: static private int GetValue(string prompt, int min, int max)
        //Purpose: Inputs an integer value with error and range checking
        //Parameters:string prompt - prompt to display to the user
        // int min - minimum value accepted
        // int max - maximum value accepted
        //Returns: int - value accepted by the method
        //*********************************************************************************************
        static private int GetValue(string prompt, int min, int max)
        {
            int value; //size from user

            //display prompt
            Console.Write($"\n{prompt}");

            //while statement checking for valid range and valid int
            while ((!int.TryParse(Console.ReadLine(), out value)) || (value < min) || (value > max))
            {
                if ((value < min) || (value > max))
                {
                    Console.WriteLine("Value out of range");
                    Console.Write($"\n{prompt}");
                }
                else
                {
                    Console.WriteLine("Please input a number");
                    Console.Write($"\n{prompt}");
                }
            }

            return value;    
        }

        //********************************************************************************************
        //Method: static private void Get Coefficients(out a, out b, out c)
        //Purpose: prompts user who Inputs a double to later be used in the quadratic
        //Parameters:
        //Returns: double a, b, c, d - Coefficients input by user
        //*********************************************************************************************
        static private void GetCoefficients(out double a, out double b, out double c)
        {
            double d; // upper half of quadratic equation to check for valid number

            //prompt user using GetValue method for each coefficient
            a = GetValue("Enter a value for a: ");

            b = GetValue("Enter a value for b: ");

            c = GetValue("Enter a value for c: ");

            //calculate for real number
            d = (b * b) - (4 * a * c);

            //error trap for non real number
            while (d < 0)
            {

                Console.WriteLine("\nError. no real number solution exists.");

                a = GetValue("Enter a value for a: ");

                b = GetValue("Enter a value for b: ");

                c = GetValue("Enter a value for c: ");

                d = (b * b) - (4 * a * c);
                
            }
        }

        //********************************************************************************************
        //Method: static private void GetValue(int lower, int upper)
        //Purpose: Inputs an integer value
        //Parameters:string prompt - prompt to display to the user
        //Returns: lower - lower limit of x
        // upper - upper limit of x
        //*********************************************************************************************
        static private void GetRange(out int lower, out int upper)
        {

            //Two prompts using get value for upper and lower limits
            lower = GetValue("Enter the lower limit: ", -8, 8);

            upper = GetValue("Enter the upper limit: ", -8, 8);

            //error trap to ensure upper is a greater number than lower
            while (lower > upper)
            {
                Console.WriteLine("Invalid. lower limit must be less than upper limit.");

                lower = GetValue("Enter the lower limit: ", -10, 10);

                upper = GetValue("Enter the upper limit: ", -10, 10);
            }

        }

        //********************************************************************************************
        //Method: static private double Quadratic(ref a, ref b, ref c)
        //Purpose: calculates the root for x
        //Parameters:
        // ref double a, b, c - pulls these refs from GetCoefficients
        // 
        //Returns: double - value accepted by the method
        //*********************************************************************************************
        static private double Quadratic(ref double a, ref double b, ref double c)
        {
            double d, rootOne, rootTwo; //roots calculated by equation

            // calculate upper half of quadratic
            d = b * b - 4 * a * c;

            //calculate root one value when d = 0
            if (d == 0)
            {
                
                rootOne = -b / (2.0 * a);

                return rootOne;
                                
            }
            
                //returns root of x
                rootOne = (-b + Math.Sqrt(d)) / (2 * a);
                rootTwo = (-b - Math.Sqrt(d)) / (2 * a);

                return rootOne;
        }

        //********************************************************************************************
        //Method: static private void DrawGraph(ref int lower, ref int upper, ref double a, ref double b, ref double c, ref double rootOne)
        //Purpose: creates quadratic graph and displays it
        //Parameters:ref - upper, lower values selected by user
        //ref - a, b, c - coefficients selected by user
        //ref - rootOne - root of x
        
        //*********************************************************************************************
        static private void DrawGraph(ref int lower, ref int upper, ref double a, ref double b, ref double c, ref double rootOne)
        {
            //add gdi drawer wiondow
            CDrawer Canvas = new CDrawer(800, 600);

            //Create y axis 
            Point newPoint = new Point();
            newPoint.X = 400;
            newPoint.Y = 600;
            Canvas.AddLine(newPoint, 800, 0, Color.Green, 2);

            //Create x axis
            Point newPoint2 = new Point();
            newPoint2.X = 0;
            newPoint2.Y = 300;
            Canvas.AddLine(newPoint2, 800, (Math.PI/2), Color.Green, 2);

            // Create ticks along the y axis
            for (int x = 0; x < 800; x = x+50)
            {
                Point newPointtickX = new Point();
                newPointtickX.X = 0 +x;
                newPointtickX.Y = 305;

                Canvas.AddLine(newPointtickX, 10, 0, Color.Green, 2);

            }

            //create ticks along the x axis
            for (int y = 0; y < 800; y = y + 50)
            {
                Point newPointtickY = new Point();
                newPointtickY.X = 395;
                newPointtickY.Y = 0 + y;

                Canvas.AddLine(newPointtickY, 10, (Math.PI/2), Color.Green, 1);
            }
            
            //for loop drawing out the left arm of the quadratic
            for (double x = 0; x < 600; x--)
            {
                //initialize y at 0
                double y = 0;

                // start the offset to start at the 0,0 of the x and y axis'
                double xOffset = 400 + (rootOne * 50);
                double yOffset = 300 + (c * -50);

                //run the x through the equation to give us a y vlaue
                y = (a * Math.Pow(x, 2)) + (b * x) + c;
                
                
                //use tiny ellipses to display graph
                Canvas.AddEllipse((((int)xOffset) - (int)x * 8), ((int)yOffset - (int)y), 1, 1, Color.White, 1, Color.White);
                
                //break it off so it doest go infinanately
                if (((int)yOffset + (int)y) > 1800)
                {
                    break;
                }
            }

            //for loop doing the exact same thing in the opposite direction for the right arm of the quadratic
            for (double x = 0; x < 1200; x++)
            {
                double y = 0;

                double xOffset = 400 + (rootOne * 50);
                double yOffset = 300 + (c * -50);

                y = (a * Math.Pow(x, 2)) + (b * x) + c;

               
                Canvas.AddEllipse((((int)xOffset) - (int)x * 8), ((int)yOffset - (int)y), 1, 1, Color.White, 1, Color.White);

                //if (((int)yOffset + (int)y) > 1200)
               // {
                   // break;
               // }

            }
            
        }

        //********************************************************************************************
        //Method: static private void YesNo(string prompt)
        //Purpose: provides option to run the program again
        //Parameters:prompt - option to run again
        

        //*********************************************************************************************
        static private string YesNo(string prompt)
        {
            string userInput; // users selection held in a string 

            //prompt the user to make a selection
            Console.Write(prompt);
            userInput = Console.ReadLine();

            //trap the user in a while for invalid selection 
            while (userInput.ToLower() != "yes" && userInput.ToLower() != "no")
            {
                Console.WriteLine($"Invalid selection");
                Console.Write(prompt);
                userInput = Console.ReadLine();
            }

            //if ststement for the user selection no
            if (userInput.ToLower() == "no")
            {
                Console.ReadKey();
            }

            //returns string
            return userInput;
        }

    }    
}
