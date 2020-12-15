﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ICA16_Textfilesgrades_TaylorHostin
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameArray = new string[1];//initialize names
            double[] markArray = new double[1];//initialize marks
            int userInput=0;                   //initialize selected amount of students and grades
      
            Console.WriteLine("\t\t\t\t\t\tTaylor Hostin Assignment 16 ");

            MakeSelection(ref nameArray, ref markArray, ref userInput);

        }

        //**************************************************************************************
        //Method: static private void MakeSelection(ref string[] nameArray, ref double[] markArray, ref int userInput)
        //Purpose: queue the user to input to select each option and loop it then ref all generated variables
        //ref string[] nameArray-array of names
        //ref double[] markArray-array of marks
        //ref int userInput-users desired length of list
        //**************************************************************************************
        static private void MakeSelection(ref string[] nameArray, ref double[] markArray, ref int userInput)
        {
            char userSelection;//operation

            //do while reapeating list
            do
            {
                //display menu
                Console.WriteLine("\nr. Read student data from a file.");
                Console.WriteLine("w. write student data to a file.");
                Console.WriteLine("g. Generate random student data.");
                Console.WriteLine("a. display the average.");
                Console.WriteLine("f. Display a list of failing students.");
                Console.WriteLine("q. Quit the program.");

                Console.Write("\nYour selection: ");
                userSelection = char.Parse(Console.ReadLine().ToLower());
                

                //switch statement catching each selection 
                switch (userSelection)
                {
                    case 'r':
                        //flag checking to see if the grade was generated first
                        if (markArray.Length == 1)
                        {
                            Console.WriteLine("NEED TO GENERATE FIRST");
                            break;
                        }

                        //display text lines from the file
                        try
                        {


                            var path = @"Test.txt";

                            var enumLines = File.ReadLines(path, Encoding.UTF8);
                           
                            foreach (var line in enumLines)
                            {
                              
                                Console.WriteLine(line);
                            }
                        }

                        //catch any errors with an error message
                        catch(Exception ex)
                        {
                            Console.WriteLine("An error occured");
                            Console.WriteLine($"The error was {ex.Message}");
                        }
                        break;

                    case 'w':
                        //check for generated
                        if (markArray.Length == 1)
                        {
                            Console.WriteLine("NEED TO GENERATE FIRST");
                            break;
                        }

                        StreamWriter swOutFile;//create file stream variable
                        
                        //try catch writing to the file the list of students
                        try
                        {
                            
                            swOutFile = new StreamWriter("Test.txt");

                            //use columns to organize write lines
                            swOutFile.Write($"\n{"Name",15:C} Mark");
                            swOutFile.Write($"\n{"----",15:C} ----");

                            //for loop displaying each name and grade until it reaches the users desired amount
                            for (int i = 0; i < userInput; i++)
                            {

                                swOutFile.Write($"\n{nameArray[i],15:C} : {markArray[i]}");
                            }

                            swOutFile.Close();
                        }
                        //error catch for all exceptions
                        catch (Exception ex)
                        {
                            Console.WriteLine("An error occured");
                            Console.WriteLine($"The error was {ex.Message}");
                        }

                        break;

                    case 'g':

                        //call generate method
                        Generate(ref nameArray, ref markArray, ref userInput);

                        break;

                    case 'a':

                        //Check for generation first
                        if (markArray.Length == 1)
                        {
                            Console.WriteLine("NEED TO GENERATE FIRST");
                            break;
                        }
                        //call average method
                        Average(nameArray, markArray, userInput);

                        break;

                    case 'f':

                        //check for generation first
                        if (markArray.Length == 1)
                        {
                            Console.WriteLine("NEED TO GENERATE FIRST");
                            break;
                        }
                        //call fail method
                        Fails(nameArray, markArray, userInput);

                        break;

                }

            } while (userSelection != 'q');
           

        }

        //********************************************************************************************
        //Method: static private void Generate(ref string[] nameArray, ref double[] marksArray, ref int userInput)
        //Purpose: randomly generates grades and names and indexes them into arrays
        //Returns: string[] nameArray - random name
        //double[] marksArray - random mark
        //*********************************************************************************************
        static private void Generate(ref string[] nameArray, ref double[] markArray, ref int userInput)
        {


            userInput = GetValue("\nEnter the number of students in the class: ", 4, 10);

            nameArray = new string[userInput]; //generated names
            markArray = new double[userInput]; //generated marks

            MakeRecords(ref nameArray, ref markArray, ref userInput);

            //Show(userInput, nameArray, markArray);
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
            Console.Write(prompt);

            //while statement checking for valid range and valid int
            while ((!int.TryParse(Console.ReadLine(), out value)) || (value < min) || (value > max))
            {
                if ((value < min) || (value > max))
                {
                    Console.WriteLine("Value out of range");
                    Console.Write(prompt);
                }
                else
                {
                    Console.WriteLine("Please input an integer");
                    Console.Write(prompt);
                }
            }

            return value;
        }

        //********************************************************************************************
        //Method: static private void MakeRecords(ref string[] nameArray, ref double[] marksArray, ref int userInput)
        //Purpose: randomly generates grades and names and indexes them into arrays
        //Returns: string[] nameArray - random name
        //double[] marksArray - random mark
        //*********************************************************************************************
        static private void MakeRecords(ref string[] nameArray, ref double[] marksArray, ref int userInput)
        {
            Random random = new Random();
            Random random2 = new Random();
            Random random3 = new Random();
            //for loop adding 1 to i until the loop hits the user input creating a spot in the array for each number up to the user input
            for (int i = 0; i < userInput; i++)
            {
                double mark;//generated mark
                char letter;//each randomly generated number

                //randomly generate mark
              
                int integer = random.Next(1, 100);
                double doub = random.NextDouble();

                mark = integer + (Math.Round(doub, 1));

                marksArray[i] = mark;

                //randomly generate length of name
               
                int length = random.Next(5, 13);


                // creating a StringBuilder object()
                StringBuilder str_build = new StringBuilder();
            



                //for loop picking randomly generated letters and putting them into a string
                for (int j = 0; j < length; j++)
                {

                    double flt = random.NextDouble();
                    int shift = Convert.ToInt32(Math.Floor(25 * flt));
                    letter = Convert.ToChar(shift + 65);
                    if (j != 0)
                    {
                        letter = char.ToLower(letter);
                    }

                    str_build.Append(letter);

                }

                //assign letters to an array
                nameArray[i] = (str_build.ToString());

            }
        }

        static private void Show(int userInput, string[] nameArray, double[] markArray)
        {
            //use columns to organize write lines
            Console.Write($"\n{"Name",15:C} Mark");
            Console.Write($"\n{"----",15:C} ----");

            //for loop displaying each name and grade until it reaches the users desired amount
            for (int i = 0; i < userInput; i++)
            {

                Console.Write($"\n{nameArray[i],15:C} : {markArray[i]}");
            }

        }

        //********************************************************************************************
        //Method: static private void Average(string[] nameArray, double[] markArray, int userInput)
        //Purpose: finds average grade fom students adn shows the student closest to average
        //Returns: string[] nameArray - random name
        //double[] marksArray - random mark
        //*********************************************************************************************
        static private void Average(string[] nameArray, double[] markArray, int userInput)
        {
            double total = 0; //total to find average
            double average;  //calculated average

            //add each mark to the total
            for (int i = 0; i < userInput; i++)
            {
                total += markArray[i];
            }

            //divide by amount of marks
            average = total / userInput;


            //order based on which mark is closest to the average after subracting the average from the mark
            var nearest = markArray.OrderBy(x => Math.Abs((long)x - average)).First();
            int placeholder = 0;

            //find the index of the mark and use that index to find the student with that mark
            for (int i = 0; i < userInput; i++)
            {
                if (markArray[i] == nearest)
                {
                    placeholder = i;
                }
            }

            //display average and closest to average student 
            Console.WriteLine($"\n\nThe average of the marks is {average:F1} percent.");
            Console.WriteLine($"{nameArray[placeholder]} with {nearest} is closest to the average. ");

        }

        //********************************************************************************************
        //Method: static private void Fails(string[] nameArray, double[] markArray, int userInput)
        //Purpose: pass marks and names and display all failing students 
        //*********************************************************************************************
        static private void Fails(string[] nameArray, double[] markArray, int userInput)
        {
            //display writeline
            Console.WriteLine("\nHere is a list of failing students...");
            Console.Write($"\n{"Name",15:C} Mark");
            Console.Write($"\n{"----",15:C} ----");

            //for loop for each array with an if statement collecting the failing marks and displaying them
            for (int i = 0; i < userInput; i++)
            {

                if (markArray[i] < 50)
                {
                    Console.Write($"\n{nameArray[i],15:C} : {markArray[i]}");
                }
            }
        }

    }

}
