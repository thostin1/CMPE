using System;
using System.Linq;

namespace ForExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Taylor", "Sucks", "Big", "Dong" };
            for (int i = 0; i < cars.Count(); i++)
            {
                Console.WriteLine(cars[i]);
                Console.ReadLine();
            } 

        }
    }
}
