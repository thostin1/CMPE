//**************************************************************************************************************************************************
//Taylor Hostin Assignment 3
//**************************************************************************************************************************************************

using System;
using System.Runtime.InteropServices;

namespace ICA03_Circ_Sphere_Assignment_Taylor_Hostin
{
    class Program
    {
        static void Main(string[] args)
        {
            // claim values
            double rad, a, v;
            string calcType; // The calculation type (area or volume)

            Console.CursorLeft = 40;
            Console.WriteLine("Taylor Hostin Assignment 3");

            //Display the radius input sentance
            Console.Write("\nEnter the radius of a circle or a sphere: ");
            rad = double.Parse(Console.ReadLine());
            
            // Display an error message if user inputs a negative value using if, else strategy.
            if (rad < 0)
            {
                Console.Write("\nYou have entered an invalid radius value. The program will exit.\n\nPress any key to exit: ");
                Console.ReadLine();
            }
            
            else           
            {
                // Provide calculations assigned to double values to find area and volume
                v = (4 / 3) * Math.PI * Math.Pow(rad, 3);
                a = Math.PI * Math.Pow(rad, 2);
                Console.Write("Please enter the desired calculation ('area' or 'volume'): ");
                
                // convert all capitals to lower case for the area or volume choice
                calcType = Console.ReadLine().ToLower();
                
                // Create a calculation output depending on whether the user inputs 'area' or 'volume' using if, else and if else.                            
                if (calcType == "area")
                {
                    // Use a Fixed 'F' formatter to display to one decimal place
                    Console.Write($"\nThe area of a circle with a radius of {rad} cm is {a:F1} square cm.");
                    Console.Write("\n\nPress any key to exit: ");
                    Console.ReadLine();
                }
               
                else if (calcType == "volume")
                {
                    // Use a Fixed 'F' formatter to display to one decimal place
                    Console.Write($"\nThe volume of a sphere with a radius of {rad} cm is {v:F1} cubic cm.");
                    Console.Write("\n\nPress any key to exit: ");
                    Console.ReadLine();
                }
                
                else
                {   //Else statement contains anything 'else' than volume or area the program errors.
                    Console.WriteLine("\nYou have entered an invalid calculation. The program will exit.\n\nPress any key to exit: ");
                    Console.ReadLine();
                }
                
            }





            }         

            
           
            
        }
    }

 