﻿//*****************************************************************************************************************
// Taylor Hostin Assignment 11
//*****************************************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA11_Methodsrefandout_TaylorHostin
{
    class Program
    {
        static void Main(string[] args)
        {
            int iMinInput;      //track minutes input by user
            int iSecInput;      //track seconds input by user
            int iMinTotal = 0;  //total music minutes
            int iSecTotal = 0;  //total music seconds
            bool bExit = false; //flag for CD is full

            //repeat until user is done of CD is full
            do
            {
                //get the time for a single track
                GetTrack(out iMinInput, out iSecInput);

                //add the track to the current music total time
                AddTrack(iMinInput, iSecInput, ref iMinTotal, ref iSecTotal);

                // display the total time
                DisplayTotal(iMinTotal, iSecTotal);

                // check for the CD being full at about 76 minutes
                if (SecTotal(iMinTotal, iSecTotal) > 76 * 60)
                {
                    Console.WriteLine("The CD is full, exiting...");
                    bExit = true;
                }
            } while ((YesNo("Add another track?") == "yes") && !bExit);
        }

        //********************************************************************************************
        //Method: static private void GetTrack(out int minutes, out int seconds)
        //Purpose: Holds Get int method and throws it intoa  string
        //Parameters:
        // int minutes - minutes held in a variable
        // int seconds - seconds held in a variable
        //*********************************************************************************************
        static private void GetTrack(out int minutes, out int seconds)
        {
           
            minutes = GetInt("\nEnter track minutes: ", 0, 60);
            
            
            seconds = GetInt("\nEnter track seconds: ", 0 , 60);           
        }

        //********************************************************************************************
        //Method: static private void AddTrack(int iMinInput, int iSecInput, ref int iMinTotal, ref int iSecTotal)
        //Purpose: adds together the seconds everytime the user adds a track and has a restriction on allowing seconds to surpass 59
        //Parameters: ref int iMintotal - references the total of minutes
        // ref int iSecTotal - referencses the total of seconds
        // int iMinInput - minutes held in a variable input by user
        // int iSecInput - seconds held in a variable input by user
        //*********************************************************************************************
        static private void AddTrack(int iMinInput, int iSecInput, ref int iMinTotal, ref int iSecTotal)
        {
            //create totals to display
            iMinTotal = iMinTotal + iMinInput;
            iSecTotal = iSecTotal + iSecInput;
            
            //while statement stopping seconds going passed 60
            while (iSecTotal >= 60)
            {
                iMinTotal++;
                iSecTotal = iSecTotal - 60;
            }
        }

        //********************************************************************************************
        //Method: static private void DisplayTotal(int iMinTotal, int iSecTotal)
        //Purpose: Displays the total time thus far
        //Parameters:
        // int iMinInput - minutes held in a variable input by user
        // int iSecInput - seconds held in a variable input by user
        //*********************************************************************************************
        static private void DisplayTotal(int iMinTotal, int iSecTotal)
        {
                       
               Console.WriteLine($"\nCurrent total = {iMinTotal:D2}:{iSecTotal:D2} ");
            
        }

        //********************************************************************************************
        //Method: static private int SecTotal(int iMinTotal, int iSecTotal)
        //Purpose: Converts minutes to seconds
        //Parameters:
        // int iMinTotal - 
        // int iSecTotal - 
        //Returns: int minToSec - the converted smins to secs
        //*********************************************************************************************
        static private int SecTotal(int iMinTotal, int iSecTotal)
        {
            int minToSec; //variable thats converting the mins to seconds

            //multiply the minutes by 60
            minToSec = iMinTotal * 60 + iSecTotal;

            //return variable
            return minToSec;
        }

        //********************************************************************************************
        //Method: static private string YesNo(string prompt)
        //Purpose: Method that holds code to accept a yes or no option to add a new track
        //Parameters:        
        // string prompt - prompts the user to type in yes or no 
        //Returns: int minToSec - the converted smins to secs
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

            //if ststement for the user selection no with a bye message
            if (userInput.ToLower() == "no")
            {
                Console.WriteLine("Bye!");
                Console.ReadKey();
            }

            //returns string
            return userInput;
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

                //input by user for the mintues or seconds
                Console.Write($"{prompt}");
               

                //create a while loop with parameters detecting for invalid inputs
                while ((!int.TryParse(Console.ReadLine(), out num) || (num < min) || (num > max)))
                {
                    //detects for invalid range message
                    if ((num < min) || (num > max))
                    {
                        //Invalid loop forcing user to input correct value
                        Console.WriteLine("\nThat value was out of range.");
                        Console.Write($"{prompt}");
                    }
                    
                    //detects for invalid string message
                    else
                    {   
                        Console.WriteLine("\nAn invalid number was entered, please try again.");
                        Console.Write($"{prompt}");
                    }
                }

                //returning the users input
                return num;
         }
        
    }
}