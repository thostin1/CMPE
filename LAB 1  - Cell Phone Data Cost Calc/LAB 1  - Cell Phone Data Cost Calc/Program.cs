﻿using System;
using System.Runtime.InteropServices;

namespace Assignment2EnergyDrinkCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDozen, cansRemain, numOfSix, numOfCans;
            string name;
            double costOfDozen, costOfSix, costOfOne;
        
            Console.WriteLine("\t\t\t\t\t\tTaylor Hostin Assignment 02 \n");
            Console.Write($"Enter the name of the energy drink: ");
            name = Console.ReadLine();
            Console.Write($"Enter the cost of a dozen of {name}: ");
            costOfDozen = double.Parse(Console.ReadLine()); 
            Console.Write($"Enter the cost of a six pack of {name}: ");
            costOfSix = double.Parse(Console.ReadLine());
            Console.Write($"Enter the cost of a single can of {name}: ");
            costOfOne = double.Parse(Console.ReadLine());
            Console.Write($"Enter the number of {name} cans to purchase: ");
            numOfCans = int.Parse(Console.ReadLine());
            // Divide the number of cans by 12 to get whole number
            numOfDozen = numOfCans / 12;
            // Modulus number of cans to get the remainder
            cansRemain = numOfCans % 12;
            // Divide the Remaining cans by six to get whole number
            numOfSix = cansRemain / 6;
            // Modulus number of cans remaining to get number of single cans
            cansRemain = cansRemain % 6;
         
            Console.Write("\n--------------------------------------------------------------------");
            Console.Write($"\n");
            Console.Write($"\nDozens to purchase: {numOfDozen} @ {costOfDozen:C2} = {costOfDozen * numOfDozen:C2}");
            Console.Write($"\n6 packs to purchase: {numOfSix} @ {costOfSix:C2} = {costOfSix*numOfSix:C2}");

            Console.Write($"\nDozens to purchase: {cansRemain} @ {costOfOne:C2} = {costOfOne*cansRemain:C2}");
            //Calculate the total cost 
            Console.Write($"\n\nTotal cost: {(costOfDozen * numOfDozen) + (costOfSix * numOfSix) + (costOfOne * cansRemain):C2}");
            Console.Write("\n\nPress any key to exit:");
            Console.ReadLine();

        }
    }
}
