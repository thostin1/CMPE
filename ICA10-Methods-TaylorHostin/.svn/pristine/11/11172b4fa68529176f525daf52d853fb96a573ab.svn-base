//*****************************************************************************************************
//Program: Assignment 10 Methods
//Description: Displays stars in GDIDrawer
//Date: Nov. 2 2020
//Author: Taylor Hostin
//Course: CMPE1300
//*****************************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;
using System.Runtime.CompilerServices;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;

namespace ICA10_Methods_TaylorHostin
{
    class Program
    {
        static void Main(string[] args)
        {
            double degToRad;    //Degrees to radians
            int length;         //Length of star lines
            int starSpacing;    //Length of spaces between stars
            string userSelect;  //user selection to replay the program
            
            //do while loop to restart program
            do

            {
                //Start canvas
                CDrawer Canvas = new CDrawer(800, 600);
                
                //clear windows
                Console.Clear();
                Canvas.Clear();

                //display name
                Console.WriteLine("\t\t\t\t\t\tICA10 Taylor Hostin");

                
               
                //get first method to retrieve user input of star line length
                length = GetInt("Enter the line length in pixels", 2, 50);

                //get second (double) method to retrieve user input for the angle
                degToRad = GetDouble("Enter the angle increment in degrees", 2, 40);

                //get method to convert degrees to radians
                degToRad = Deg2Rad(degToRad);

                //get first method to retrieve user input of star spacing
                starSpacing = GetInt("Enter the spacing for the stars in pixels", 10, 150);

                //nested for loops to print out the stars which are creating using the DrawStar method
                for (int x = 0; x <= Canvas.ScaledWidth; x += starSpacing)
                {
                    for (int y = 0; y <= Canvas.ScaledHeight; y += starSpacing)
                    {
                        DrawStar(Canvas, x, y, length, degToRad);                        
                    }                    
                }

                //option to run the program again
                Console.Write("\nRun the program again? (y/n): ");
                userSelect = Console.ReadLine();

            //while portion of do while loop
            } while (userSelect == "y" || userSelect == "Y");
        }

        //********************************************************************************************
        //Method: static private int GetInt(string prompt, int min, int max)
        //Purpose: Inputs an integer value with error and range checking
        //Parameters:string prompt - prompt to display to the user
        // int min - minimum value accepted
        // int max - maximum value accepted
        //Returns: int - value accepted by the method
        //*********************************************************************************************
        static private int GetInt(string prompt, int min, int max)
        {

            int num; //num input by user

            //input by user for the star length and spacing
            Console.Write($"{prompt}: ");
            int.TryParse(Console.ReadLine(), out num);

            //create a while loop with parameters detecting for invalid inputs
            while ((num < min) || (num > max) || (num == 0))
            {
                //Invalid loop forcing user to input correct value
                Console.Write($"Invalid: {prompt} Mininum : {min} Maximum : {max}. Enter again: ");                
                int.TryParse(Console.ReadLine(), out num);
            }

            //returning the users input
            return num;
        }

        //********************************************************************************************
        //Method: static private double GetDouble(string prompt, int min, int max)
        //Purpose: Inputs an double value with error and range checking
        //Parameters:string prompt - prompt to display to the user
        // int min - minimum value accepted
        // int max - maximum value accepted
        //Returns: double - value accepted by the method
        //*********************************************************************************************
        static private double GetDouble(string prompt, int min, int max)
        {            
            double degrees; //users input for degrees

            //input by user for degrees between lines
            Console.Write($"{prompt}: ");
            double.TryParse(Console.ReadLine(), out degrees);

            //loop with parameters for the allowed degrees as a variable along with error prompt forcing user to input a correct value
            while ((degrees < min) || (degrees > max) || (degrees == 0))
            {
                Console.WriteLine($"Invalid: {prompt} Mininum : {min} Maximum : {max}. Enter again: ");
                double.TryParse(Console.ReadLine(), out degrees);
            }
            return degrees;
        }

        //********************************************************************************************
        //Method: static private double GetDouble(string prompt, int min, int max)
        //Purpose: Holds a formula converting degrees to radians
        //Parameters: convert - holds the calculated result
        //Returns: double - value in radians
        //*********************************************************************************************
        static private double Deg2Rad(double convert)
        {
            //returns the users input in radians after it passes through this method from the GetDouble method
            return (convert * Math.PI / 180);
        }

        //********************************************************************************************
        //Method: static private void DrawStar(canvas, int x, int y, double length, double angle)
        //Purpose: Takes all user inputs from previous methods and creates a star
        //Parameters: double length - previous user input
        // double angle - previuos user input
        // int x - x coordinate of lines in star
        // int y - y coordinate of lines in star
        //*********************************************************************************************
        static private void DrawStar(CDrawer canvas, int x, int y, double length, double angle)
        {
            //random generator for the colours
            Random rndGen = new Random();

            //coordinates for the lines
            Point point = new Point();
            point.X = x;
            point.Y = y;

            //create for loop that adds the lines until the lines do a full 360 degree round
            for (double i = 0; i < 360; i = i + angle)
            {
                //draw a line with user input length
                canvas.AddLine(point, length, i, Color.FromArgb(rndGen.Next()), 1);
            }
        }


    }
}
