//*************************************************************************************
// Taylor Hostin Assignment 15
//*************************************************************************************
using System;
using System.Linq;
using System.Text;

namespace ICA15_StudentRecord_TaylorHostin
{
    class Program
    {
        static void Main(string[] args)
        {
            string runAgain; //option to run program again

            do
            {

                Console.Clear();

                int userINput; //amount of students

                Console.WriteLine("\t\t\t\t\t\tTaylor Hostin Assignment 16 ");

                userINput = GetValue("\nEnter the number of students in the class: ", 4, 10);
  
                string[] nameArray = new string[userINput]; //generated names
                double[] markArray = new double[userINput]; //generated marks

                MakeRecords(ref nameArray, ref markArray, ref userINput);

                Show(userINput, nameArray, markArray);

                Average(nameArray, markArray, userINput);

                Fails(nameArray, markArray, userINput);

                Console.Write("\n\nRun program again(y/n)? ");
                runAgain = Console.ReadLine();

            } while (runAgain == "y" || runAgain == "Y");

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

            //for loop adding 1 to i until the loop hits the user input creating a spot in the array for each number up to the user input
            for (int i = 0; i < userInput; i++)
            {
                double mark;//generated mark
                char letter;//each randomly generated number

                //randomly generate mark
                Random random = new Random();
                int integer = random.Next(1, 100);
                double doub = random.NextDouble();

                mark = integer + (Math.Round(doub, 1));

                marksArray[i] = mark;

                //randomly generate length of name
                Random random2 = new Random();
                int length = random.Next(5, 13);
                

                // creating a StringBuilder object()
                StringBuilder str_build = new StringBuilder();
                Random random3 = new Random();

                

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

        //********************************************************************************************
        //Method: static private void show(ref string[] nameArray, ref double[] marksArray, ref int userInput)
        //Purpose: passed values to be dispalyed on the console
        //*********************************************************************************************
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
            double total =0; //total to find average
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
