//*************************************************************************************************************
// Taylor Hostin Assignment 13
//*************************************************************************************************************

using System;


namespace ICA13_MethodsandArrays_TaylorHostin
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;   //user selection to restart program

            //re run program
            do
            {
                Console.WriteLine("\t\t\t\t\t\tTaylor Hostin Assignment 13");

                Console.Clear();

                int arraySize;       //array size chosen by user 
                int[] newArray;      //the array 
                double arrayAvg;     //average object value
                int largestIndex = 0;//largest index location value   


                arraySize = GetValue("\nEnter the size of the array: ", 4, 10);

                newArray = MakeArray(arraySize);

                Show(newArray, arraySize);

                ShowReverse(newArray, arraySize);

                arrayAvg = Average(newArray, arraySize);

                //display average
                Console.WriteLine($"\nThe average is {arrayAvg}");

                largestIndex = Largest(newArray, arraySize);

                //display average
                Console.WriteLine($"\nThe largest value is {newArray[largestIndex]} at location {largestIndex}");

                //option to run again
                Console.Write("\nRun again? y/n: ");
                userInput = Console.ReadLine();



            } while ((userInput == "y") || (userInput == "Y"));

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
            while((!int.TryParse(Console.ReadLine(), out value))||(value < min)||(value > max))
            {
                if ((value < min)|| (value > max))
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
        //Method: static private int[] MakeArray(int size)
        //Purpose: Inputs an integer value with error and range checking
        //Parameters:
        // int size - minimum value accepted
        //Returns: int[] newArray - array created by the method
        //*********************************************************************************************
        static private int[] MakeArray(int size)
        {
            int[] newArray = new int[size]; //create array and set index to size

            //random generator for index object value
            Random ranNum = new Random();
            
            //loop to display array index values
            for (int i = 0; i < size; i++)
            {                
                newArray[i] = ranNum.Next(0, 101);
            }

            return newArray;
        }

        //********************************************************************************************
        //Method: static private void ShowReverse(int[] array, int size)
        //Purpose: displays values of array
        //Parameters: int[] array - passes the array
        //int size - size of array chosen by user
        //*********************************************************************************************
        static private void Show(int[] array, int size)
        {
            
            //display the contents of array using a for loop
            Console.WriteLine("\nThe array contents...");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
                
               
            }
            
          
        }
        //********************************************************************************************
        //Method: static private void ShowReverse(int[] array, int size)
        //Purpose: displays values of array in reverse
        //Parameters: int[] array - passes the array
        //int size - size of array chosen by user
        //Returns: int largestIndex - value calculated by the method
        //*********************************************************************************************
        static private void ShowReverse(int[] array, int size)
        {
            Console.WriteLine("\nThe array in reverse...");
            
            //display contents of array using for loop
            for (int i = size-1; i >= 0; i--)
            {
                Console.WriteLine($"array[{i}] = {array[i]}");
            }
        }

        //********************************************************************************************
        //Method: static private double Largest(int[] array, int size)
        //Purpose: calculates average object value
        //Parameters: int[] array - passes the array
        //int size - size of array chosen by user
        //Returns: ddouble objectAvg - value calculated by the method
        //*********************************************************************************************
        static private double Average(int[] array, int size)
        {
            double objectSum = 0; //sum of objects
            double objectAvg;     //average value of objects
           
            //For loop adding each object value together
            for (int i = 0; i < size; i++)
            {
                objectSum += array[i];

            }

            //divide sum by amount of index's
            objectAvg = objectSum / size;



            return objectAvg;
        }

        //********************************************************************************************
        //Method: static private int Largest(int[] array, int size)
        //Purpose: calculates largest object index location
        //Parameters: int[] array - passes the array
        //int size - size of array chosen by user
        //Returns: int largestIndex - value calculated by the method
        //*********************************************************************************************
        static private int Largest(int[] array, int size)
        {
            
            int largestObject = array[0]; //start object check at array value 0
            int largestIndex = 0;         //index of largest value

            //add to the index every loop/(check)
            for (int i = 0; i < size; i++)
            {
                if(largestObject < array[i])
                {
                    largestIndex = i;
                }

            }  
            
            return largestIndex;
        
        }

    }
}
