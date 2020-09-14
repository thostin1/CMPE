using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cans = 0;
            double cpc;


            Console.WriteLine("\t\t\t\t\t\tICA01 - Taylor Hostin");
            
            
                Console.Write("\nEnter the number of cans of pop to purchase: ");
                cans = int.Parse(Console.ReadLine());
            
            Console.Write("Enter the cost per can: ");
            cpc = double.Parse(Console.ReadLine());

            double gst = ((cans * cpc) * 0.05);
            Console.Write($"\nThe GST is {gst:C2}", gst);

            double tc = gst + (cans + cpc);
            Console.Write($"\n\nThe total cost is {tc:C2}", tc);

            Console.Write("\n\nPress the <enter> key to exit:");


            Console.ReadLine();
        }
    }
}
