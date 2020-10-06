using System;

namespace Exercise_3_Sot_Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            double v, d;    //Velocity and distance claimed as double values
            double a;       //angle claimed as a double value

            Console.WriteLine("Shot Distance");
            
            //Input line for user for the muzzle velocity of the shot
            Console.Write("\nEnter the muzzle velocity in meters per second: ");
            v = double.Parse(Console.ReadLine());

            //Angle the cannon will be shooting at also a user input as a double value using parse as an identifier to make the angle a variable
            Console.Write("Enter the cannon angle in degrees: ");
            a = double.Parse(Console.ReadLine());

            //change the angle from degrees to radians so Math.Cos will calculate properly
            //Putting the multiplication symbol before the equals sign is the same as saying: 'a = a * Math.PI / 180'
            a *= Math.PI / 180;
            
            //input formula for measuring distance using Math., Multiplicaton, and division.
            d = 2 * Math.Pow(v, 2.0) * (Math.Cos(a)) * (Math.Sin(a)) / 9.81;

            // Output line for user to see how far the shot will travel
            Console.WriteLine($"\nThe shot will travel {d} meters");
            
            //End program.
            Console.WriteLine("\nPress any key to exit: ");

            Console.ReadKey();

   
        }

    }
}
