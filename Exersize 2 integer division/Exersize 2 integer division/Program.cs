using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersize_2_integer_division
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfTix;
            int numOf5, numOf20, tixRemain;
            double costOf20, costOf5, costOf1, totalCost;

            //3
            Console.WriteLine("Ticket purchase");

            Console.Write("\nEnter the number of tickets to purchase: ");
            numOfTix = int.Parse(Console.ReadLine());

            numOf20 = numOfTix / 20;

            tixRemain = numOfTix % 20;

            numOf5 = tixRemain / 5;

            tixRemain = tixRemain % 5;

            
            Console.WriteLine($"\n\nYou must purchase {numOf20} 20-pack(s), {numOf5} 5-pack(s), and {tixRemain} single tickets.");
            Console.WriteLine($"\nthe total cost is {(numOf20 * 100)+(numOf5 * 30)+(tixRemain * 7.25):C2}");
            Console.WriteLine("\nPress any key to continue");

            Console.ReadKey();

        }
    }
}
