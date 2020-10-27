using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GDIDrawer;

namespace LAB02_VirtualPong_TaylorHostin
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int iX = 1;        //x ball position
            int iY = 0;        //y ball position
            int iXVel = 1; //amount ball moves in x direction for every loop
            int iYVel = 1; //amount ball moves in y direction for every loop
            Point mousePosition;
            
            
            
            //create a drawer window with a scale of 10
            CDrawer Canvas = new CDrawer();
            Canvas.Scale = 5;
           // Canvas.ContinuousUpdate = false;
            for (int i = 0; i <= 159; i++)
            {
                Canvas.SetBBScaledPixel(i, 0, Color.Turquoise);
                Canvas.SetBBScaledPixel(i, 119, Color.Turquoise);
            }
            for (int i = 0; i <= 119; i++)
            {
                Canvas.SetBBScaledPixel(159, i, Color.Turquoise);
            }//put a ternary or conditional on here so 
     
           
           // Canvas.SetBBScaledPixel(90, 60, Color.Black);
            
            
            
            //loop until the ball leaves the visible window
            while ((iX < 160) && (iX > 0))
            {
                Console.WriteLine(iX);
                Console.WriteLine(iY);
                Canvas.ContinuousUpdate = false;
                Canvas.GetLastMousePositionScaled(out mousePosition);
                mousePosition.X = 1;
                mousePosition.Y = (mousePosition.Y < (int)11.5) ? (int)11.5 : mousePosition.Y;
                
                //erase the old ball
                Canvas.Clear();

                Canvas.AddLine(mousePosition, 10.0, 0.0, Color.Red, 5) ;
                Canvas.Render();

                //draw the new ball
                Canvas.AddRectangle(iX, iY, 2, 2);
              
                Canvas.Render();

                //time delay to slow down the ball
                System.Threading.Thread.Sleep(20);
                
                //calculate the ball's new position
                iX += iXVel;
                iY += iYVel;

                //check for bouncing off of the lower edge of the window               
                if ((iY > 117) || (iY < 1))
                    
                    //reverse the y velocity (ball goes up)
                    iYVel = -iYVel;

                if (iX > 157)iXVel = -iXVel;

                
                iX = (iX > 158) ? 158 : iX;

                iY = (iY < 1) ? 1 : iY;
                iY = (iY > 118) ? 118 : iY;
                if (iX<1)
                {
                    Console.WriteLine("TEST");
                    Canvas.ContinuousUpdate = true;

                }
           
            }
          
            
            Canvas.Clear();
            Canvas.AddText("Final Score: ",25,Color.Red );
     

            Console.Read();




        }
    }

}
