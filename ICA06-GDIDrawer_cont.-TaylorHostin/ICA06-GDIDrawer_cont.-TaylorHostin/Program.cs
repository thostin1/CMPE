using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;
using System.Threading;

namespace ICA06_GDIDrawer_cont._TaylorHostin
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareSize, numSquares, xNum, yNum;

            Console.WriteLine("\t\t\t\t\t\tICA06 Taylor Hostin");




            Console.Write("Enter the size if the squares: ");
            int.TryParse(Console.ReadLine(), out squareSize);

            while (squareSize < 10 || squareSize > 200)
            {
                Console.Clear();
                Console.Write("Error: Enter the size of the squares: ");
                squareSize = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the number of squares to display: ");
            int.TryParse(Console.ReadLine(), out numSquares);

            while (numSquares < 0)
            {
                Console.Write("Error: Enter the number of squares to display: ");
                numSquares = int.Parse(Console.ReadLine());
            }
            CDrawer Canvas = new CDrawer(800, 600);

            int count = 0;
            Random randomNumber = new Random();
           

            while (count <= numSquares)
            {
                count = count + 1; //count++;
                yNum = randomNumber.Next(0, 600);
                xNum = randomNumber.Next(0, 800);

                //xNum = (xNum < (squareSize / 2 )) ? (squareSize / 2 ) : xNum;
                xNum = (xNum > (800 - (squareSize ))) ? (800 - (squareSize )) : xNum;

                
                //yNum = (yNum < (squareSize )) ? (squareSize ) : yNum;
                yNum = (yNum > (600 - (squareSize))) ? (600 - (squareSize)) : yNum;

                Canvas.AddRectangle(xNum, yNum, squareSize, squareSize, RandColor.GetColor());
      
            }
            Console.ReadLine();
        }       
    }
}
