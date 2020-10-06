
//******************************************************************************************************
// Taylor Hostin Assignment 2
//******************************************************************************************************
using System;

namespace ICA02_EnergyDrinkCalculator_TaylorHostin
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDozen;//Number of 12 packs
            int cansRemain;//Number of Singles
            int numOfSix;//Number of 6 packs
            int numOfCans;//Number of cans the user wants
            string name;//name of energy drink
            double costOfDozen, costOfSix, costOfOne;//Cost of each of the pack sizes

            //Display Assignment Title with my name
            Console.WriteLine("\t\t\t\t\t\tTaylor Hostin Assignment 02 \n");
            
            Console.Write($"Enter the name of the energy drink: ");//Display First user input
            name = Console.ReadLine();
            
            Console.Write($"Enter the cost of a dozen of {name}: ");//Display second user input (cost of a 12 pack)
            costOfDozen = double.Parse(Console.ReadLine());
            
            Console.Write($"Enter the cost of a six pack of {name}: ");//Display third user input (cost of a 6 pack)
            costOfSix = double.Parse(Console.ReadLine());
            
            Console.Write($"Enter the cost of a single can of {name}: ");//Display fourth user input (cost of a single)
            costOfOne = double.Parse(Console.ReadLine());
            
            Console.Write($"Enter the number of {name} cans to purchase: ");//Singles
            numOfCans = int.Parse(Console.ReadLine());
            // Divide the number of cans by 12 to get whole number
            numOfDozen = numOfCans / 12;
            // Modulus number of cans to get the remainder
            cansRemain = numOfCans % 12;
            // Divide the Remaining cans by six to get whole number
            numOfSix = cansRemain / 6;
            // Modulus number of cans remaining to get number of single cans
            cansRemain = cansRemain % 6;

            //Display dashed line in a really ugly way
            Console.Write("\n--------------------------------------------------------------------");
            Console.Write($"\n");
            
            //Display the amount of 12 packs 6 packs and singles the user needs to achieve the total cans and use Currency Formatting to two decimal spots
            Console.Write($"\nDozens to purchase: {numOfDozen} @ {costOfDozen:C2} = {costOfDozen * numOfDozen:C2}");
            Console.Write($"\n6 packs to purchase: {numOfSix} @ {costOfSix:C2} = {costOfSix * numOfSix:C2}");

            Console.Write($"\nDozens to purchase: {cansRemain} @ {costOfOne:C2} = {costOfOne * cansRemain:C2}");
            
            //Calculate the total cost 
            Console.Write($"\n\nTotal cost: {(costOfDozen * numOfDozen) + (costOfSix * numOfSix) + (costOfOne * cansRemain):C2}");
            Console.Write("\n\nPress any key to exit:");
            Console.ReadLine();
        }
    }
}
