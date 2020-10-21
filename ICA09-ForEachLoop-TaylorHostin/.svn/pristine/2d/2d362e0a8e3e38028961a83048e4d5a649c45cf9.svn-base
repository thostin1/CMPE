//*************************************************************************************************************************************
//Taylor Hostin Assignment 9
//**************************************************************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA09_ForEachLoop_TaylorHostin
{
    class Program
    {
        static void Main(string[] args)
        {
                string userInput;       //Users choice to re run program
           
            //Begin do while loop to re run program
            do
            {

                string passwordInput;   //The users password choice
                int upperCount = 0;     //The count of uppercase letters
                int lowerCount = 0;     //The count of lowercase letters
                int symCount = 0;       //The count of symbols used
                int numCount = 0;       //count of numbers used
                int spaceCount = 0;     //Count of spaces used
                int dupliCount = 0;     //Count of duplicate numbers used
                
                //Clear the console and display rules and instructions for the password input
                Console.Clear();
                Console.WriteLine("\t\t\t\t\t\tTaylor Hostin Assignment 9");
                Console.WriteLine("\nThe password must be compliant with the following rules:");
                Console.WriteLine("\nIt must be a minimum of 8 characters in length.");
                Console.WriteLine("There must be at least one uppercase letter.");
                Console.WriteLine("There must be at least one lowercase letter.");
                Console.WriteLine("There must be at least one symbol character");
                Console.WriteLine("There must not be any space or tab characters in the password.");
                Console.WriteLine("There must be at least two numbers in the password and they must be different.");

                //display password input command and convert it to a string
                Console.Write("\nEnter password: ");
                passwordInput = Console.ReadLine();

               
                //Create for Each statement to test each character within the string using (chLetter)
                foreach (char chLetter in passwordInput)
                {
                    //If statement testing for a capital and adding 1 to uppercount if a capital is used
                    if ((chLetter >= 'A') && (chLetter <= 'Z'))
                    {
                        
                        upperCount++;
                    }

                    //Test for a lowercase being used and add one to lowercount if a lowercase is used
                    if ((chLetter >= 'a') && (chLetter <= 'z'))
                    {

                        lowerCount++;
                    }

                    //Test for each symbol on the keyboard if one is used using the ASCII ordering system and creating a range between each
                    if ((chLetter >= '!') && (chLetter <= '/') || (chLetter >= ':') && (chLetter <= '@') || (chLetter >= '[') && (chLetter <= '`') || (chLetter == '~'))
                    {

                        symCount++;
                    }

                    //Test if a space or tab is used and add 1 to space count if it is
                    if (char.IsWhiteSpace(chLetter))
                    {

                        spaceCount++;
                    }                   
                    
                    //Test to see if a number is used and add 1 to numcount if so
                    if ((chLetter >= '0') && (chLetter <= '9'))
                    {
                        numCount++;
                        
                    }
              
                
                    //Test to see if two numbers are repeated using nested for loops and an if statement and if so add on to duplicount
                    for (var i = 0; i <= passwordInput.Length; i++)
                    {

                        for (var j = i + 1; j <= passwordInput.Length - 1; j++)
                        {

                            if (passwordInput[j] == passwordInput[i] && ((passwordInput[j] >= '0') && (passwordInput[j] <= '9')))
                            {
                               
                                dupliCount++;
                               

                            }

                        }

                    }

                }
                
                //Exit for each statement
                //Create if statement to see if there were any errors at all within the password if not it will go on to the else statement below
                if ((passwordInput.Length < 8) || (dupliCount > 0) || (lowerCount < 1) || (upperCount < 1) || (symCount < 1) || (numCount < 1) || (spaceCount > 1))
                {

                    //display error message for password too short
                    if (passwordInput.Length < 8) Console.WriteLine("\nError. Password too short");

                    //Display error message if duplicount is greater than 0
                    if ((dupliCount > 0))
                    {
                        Console.WriteLine("\nError. password contains duplicate numbers");
                    }

                    //Display error message if the lower count is less than 1
                    if (lowerCount < 1)
                    {
                        Console.WriteLine("\nError. Not enough uppercase letters");
                    }

                    //Display error message if upper count is less than 1
                    if (upperCount < 1)
                    {
                        Console.WriteLine("\nError. Not enough lowercase letters");
                    }

                    //Display error message if symcount is less than one
                    if (symCount < 1)
                    {
                        Console.WriteLine("\nError. Not enough symbols");
                    }

                    //Display error message if the number count is less than 2
                    if (numCount < 2)
                    {
                        Console.WriteLine("\nError. Not enough numbers");
                    }

                    //display an error message if space count is greater than 1
                    if (spaceCount > 1)
                    {
                        Console.WriteLine("Error. No spaces allowed");
                    }
               
                }
              
                //Else statement confirming that the password is valid along with a validation message displayed
                else
                {
                    Console.WriteLine("\nPassword accepted. Thank you.");
                }
                
                //Option for user to re run the program
                Console.Write("\nRun program again?(y/n): ");
                userInput = Console.ReadLine();
           
            //the do while loop to repeat program if user enters y or Y
            } while (userInput == "y" || userInput == "Y");
            

        }
    }
}