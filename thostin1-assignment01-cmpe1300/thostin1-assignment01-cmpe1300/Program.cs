using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thostin1_assignment01_cmpe1300
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCans = 0;
            double costPerCan;
            

            Console.WriteLine("\t\t\t\t\t\tICA01 - Taylor Hostin");


            Console.Write("\nEnter the number of cans of pop to purchase: ");
            numOfCans = int.Parse(Console.ReadLine());

            Console.Write("Enter the cost per can: ");
            costPerCan = double.Parse(Console.ReadLine());

            double salesTax = ((numOfCans * costPerCan) * 0.05);
            Console.Write($"\nThe GST is {salesTax:C2}", salesTax);

            double totalCost = salesTax + (costPerCan * numOfCans);
            Console.Write($"\n\nThe total cost is {totalCost:C2}", totalCost);

            Console.Write("\n\nPress the <enter> key to exit:");


            Console.ReadLine();
        }
    }
}
