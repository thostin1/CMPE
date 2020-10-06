
//********************************************************************************************************
//Taylor Hostin Lab 1
//********************************************************************************************************
using System;
using System.Threading;

namespace LAB1_Cell_Phone_Data_Cost_Calculator_Taylor_Hostin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define all variables and give values to them (price).
            long bytes;
            int numOfGb, numOfMb, numOfKb, bytesRemain, remainForMb, remainForKb; //Number of each storage type along with remainders for calculations
            double costOfGb = 12.00; //Cost
            double costOfMb = 0.25; //Cost
            double costOfKb = 0.02; //Cost
            double costOfBytes = 0.01; //Cost
            double subtotal, gst; // subtotal and gst
            double b = 0.95; //911 access fee
            double c = 6.95; //System access fee

            // Named Debugger window using the Console.Title application i just learned.
            Console.Title = "Lab 1 - Cell Phone Data Cost Calculator";            
            
            // Placed the title of the program in the centre of the screen.
            Console.CursorLeft = 40;
            Console.Write("Lab 1 - Cell Phone Data Cost Calculator");
            Console.Write("\n\nEnter the number of bytes used: ");
            bytes = long.Parse(Console.ReadLine());
            
            // Divided the number of bytes to get the whole number of GB required
            numOfGb = (int)(bytes / 1073741824);
            
            // Modulus number of cans to get the remainder adn repeated the process to get MB, KB, and bytes.
            remainForMb = (int)(bytes % 1073741824);
            numOfMb = remainForMb / 1048576;
            remainForKb = remainForMb % 1048576;
            numOfKb = remainForKb / 1024;
            bytesRemain = remainForKb % 1024;

            // Changed the color of the text defining amount, unit, cost per unit and total.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nAmount\tUnit\t Cost/Unit   Total");
            
            // Reset text color back to default.
            Console.ResetColor();
            
            // Code the outputs into correct colums and calculate (Amount of units * Cost/unit)
            Console.WriteLine($"\n\n{numOfGb}\tGB\t {costOfGb:C2}      {numOfGb * costOfGb:C2}");
            Console.WriteLine($"{numOfMb}\tMB\t {costOfMb:C2}       {numOfMb * costOfMb:C2}");
            Console.WriteLine($"{numOfKb}\tKB\t {costOfKb:C2}       {numOfKb * costOfKb:C2}");
            Console.WriteLine($"{bytesRemain}\tBytes\t {costOfBytes:C2}       {bytesRemain * costOfBytes:C2}");
            Console.CursorLeft = 29;
            Console.WriteLine("----------");
            
            // Aquire subtotal by adding all previous totals of Units and creating a variable to represent the subtotal
            // Aquire GST by Multiplying the total before gst by 0.05
            subtotal = (numOfGb * costOfGb) + (numOfMb * costOfMb) + (numOfKb * costOfKb) + (bytesRemain * costOfBytes);
            gst = (subtotal + b + c) * 0.05;
            
            //Display the charges that are all being added to final total including adding currency formatter to 2 decimal places.
            Console.WriteLine($"Subtotal                     {subtotal:C2}");
            Console.WriteLine($"\n911 Access Fee               {b:C2}");
            Console.WriteLine($"\nSystem Access Fee            {c:C2}");
            Console.WriteLine($"\nTotal before GST             {subtotal + b + c:C2}");
            Console.WriteLine($"\nGST                          {gst:C2}");
            Console.CursorLeft = 29;
            Console.WriteLine("----------");
            Console.WriteLine($"Total for Data:              {gst + (subtotal + b + c):C2}");
            


            Console.ReadLine();

        }
    }
}
