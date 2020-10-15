//*****************************************************************************************************************
// Taylor Hostin Assignment 7
//*****************************************************************************************************************

using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA07_DoWhile_TaylorHostin
{
    class Program
    {
        static void Main(string[] args)
        {
            int numGrades;
            
            int gInt;           //Generated whole number for sum for random grades
            double gDec;        //Generated decimal place for randomly gen'd grades
            double sum;         //sum of the two generated decimal and whole number
            double totalSum = 0;//the total sum of all the grades summed togther
            double avgGrade;    //the mean average of the grades
            int failCount = 0;  //the amount of fails variable
            string userSelect;  //user selection to re run the program


            //Begin full do while for if the user wants to rerun the program
            do
            {

                //Clear the console window
                Console.Clear();

                //Display name
                Console.WriteLine("\t\t\t\t\t\tICA07 Taylor Hostin");

                    
            
            
                
                
                //Display first user input line
                Console.Write("\nEnter the number of grades to generate: ");
                int.TryParse(Console.ReadLine(), out numGrades);

                //First do while statement creating a loop if the user inputs an invalid number if grades
                do
                {
                    //Check for if the user inputs a string and display error message
                    if (numGrades == 0)
                    {
                        Console.WriteLine("You have entered an invalid number.");
                        Console.Write("Enter the number of grades to generate: ");
                        int.TryParse(Console.ReadLine(), out numGrades);
                    }
                    
                    //check if the user inputs above 10
                    else if (numGrades > 10)
                    {
                        Console.WriteLine("You have entered a value that is too high");
                        Console.Write("Enter the number of grades to generate: ");
                        int.TryParse(Console.ReadLine(), out numGrades);
                    }
                    
                    //check if user inputs below 5
                    else if (numGrades < 5)
                    {
                        Console.WriteLine("You have enteres a value that is too low.");
                        Console.Write("Enter the number of grades to generate: ");
                        int.TryParse(Console.ReadLine(), out numGrades);
                    }


                //The while portion of the post-test loop
                } while ((numGrades == 0 || numGrades > 10 || numGrades < 5));
                
                //Display message
                Console.WriteLine("\nHere are the generated grades...");
                
                //Gap for formatting
                Console.WriteLine();

                //Set the count of the (numGrades) to 0
                int count = 0;
                
                //Create random number generator
                Random randomNumber = new Random();


                do
                {


                    //Add 1 to the count until it equals the num grades chosen by user and the program passes this loop
                    count++;

                    //Generate a random whole number and decimal place
                    gDec = randomNumber.NextDouble();
                    gInt = randomNumber.Next(0, 100);

                    //Sum them to create a grade
                    sum = gDec + gInt;

                    //Write a series of grades that will stop when the (numGrades) is satisfied
                    Console.Write($"{sum:F1} ");

                    //Create totalSum which begins at 0 and adds 1 until the loop ends providing a total sum for the mean calculation
                    totalSum = totalSum + sum;

                    //if statement to calculate the amount of fails which will add one everytime there is a grade < 50
                    if (sum < 50) failCount++;


                //Set the while statement so the count is less than the number of grades selected by the user so the program wont leave the loop until this is satisfied.
                } while (count < numGrades);

                //Create mean average grade
                avgGrade = totalSum / numGrades;

                //Display average grade with F1 formatter which will round to one decimal place
                Console.WriteLine($"\n\nThe average grade was {avgGrade:F1}%");
                
                //Display amount of failures
                Console.WriteLine($"There were {failCount} failures.");
                
                //Display option for user to run the program again
                Console.WriteLine("\nRun the program again? (y/n): ");
                userSelect = Console.ReadLine();
           
                //While statement detecting the users selection to re run the program.
            } while (userSelect == "y" ||userSelect == "Y");
            Console.ReadKey();


        }
    }
}
