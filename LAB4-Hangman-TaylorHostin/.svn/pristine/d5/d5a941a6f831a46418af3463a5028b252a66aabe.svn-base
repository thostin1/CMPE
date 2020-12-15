using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using GDIDrawer;
using System.Text.RegularExpressions;

namespace LAB4_Hangman_TaylorHostin
{
    class Program
    {
        public static void Main(string[] args)
        {
            string userInput;

            do
            {
                Console.Clear();
                
                string word;

                Console.WriteLine("\t\t\t\t\t\tTaylor Hostin Lab 4");

                word = GetWord();

                GetGuess(word);

                Console.Write("Play Again(y/n)? ");
                userInput = Console.ReadLine();

            } while (userInput == "y" || userInput == "Y");
        }
        static private string GetWord()
        {
            string word;

            int lineCount = File.ReadAllLines(@"C:\Users\T-Raw\hangmanwords.txt").Length;
            Random rnd = new Random();
            int randomLineNum = rnd.Next(lineCount);
            int indicator = 0;

            using (var reader = File.OpenText(@"C:\Users\T-Raw\hangmanwords.txt"))
            {
                while (reader.ReadLine() != null)
                {
                    if (indicator == randomLineNum)
                    {
                        word = reader.ReadLine();

                        return word;
                    }
                    indicator++;

                }
                return "empty";
            }


        }
        static private void GetGuess(string word2)
        {
            
            int count = 0;

            CDrawer Canvas = new CDrawer();

            string wrongGuesses = "";
            char[] guessed = new char[26];
            char[] printWord = word2.ToCharArray();
            char[] word = word2.ToCharArray();
            char[] set = word;
           
            char guess;
            string userInput;
            int index = 0;
            int winCount = 0;
            for (int i = 0; i < word.Length; i++)
            {
                printWord[i] = '-';
            }

            

            Console.WriteLine(printWord);

            for (int i = 0; i < 100; i++)
            {
                Console.Write("Enter your guess: ");
                userInput = (Console.ReadLine());


                Regex regex = new Regex(@"^[a-zA-Z]$");

                if (regex.IsMatch(userInput))
                {
                    guess = char.Parse(userInput);
                    
                }
                else
                {
                    while (!regex.IsMatch(userInput))
                    {
                        Console.WriteLine("Error");
                        Console.Write("Enter your guess: ");
                        userInput = (Console.ReadLine());
                    }
                    guess = char.Parse(userInput);

                }




                bool right = false;

                for (int j = 0; j < set.Length; j++)
                {
                    count++;
                    if (count > 1)
                    {
                        Canvas.Clear();
                    }
                    if (set[j] == guess)
                    {

                        Console.WriteLine("Your guess is correct.");

                        printWord[j] = guess;

                        guessed[index] = guess;

                        index++;

                        right = true;

                        winCount++;
                    }
                }

                if (right != true)
                {
                    Console.WriteLine("Your guess is incorrect.");

                    wrongGuesses = wrongGuesses + guess;

                }
                else
                {
                    right = false;
                }


                Point point = new Point();

                point.X = 300;
                point.Y = 450;

                Canvas.AddLine(point, 300, 0, Color.Turquoise, 4);

                Point point2 = new Point();

                point2.X = 300;
                point2.Y = 175;

                Canvas.AddLine(point2, 150, Math.PI / 2, Color.Turquoise, 4);

                Point point3 = new Point();

                point3.X = 225;
                point3.Y = 450;

                Canvas.AddLine(point3, 150, Math.PI / 2, Color.Turquoise, 4);

                Point point4 = new Point();

                point4.X = 380;
                point4.Y = 208;

                Canvas.AddLine(point4, 30, 0, Color.Brown, 2);

                string charStr = new string(printWord);
                //Canvas.AddText("Wrong Letters: ", )
                Canvas.AddText(charStr, 30, 350, 500, 200, 50, Color.Green);

                Console.WriteLine(wrongGuesses);

                Console.WriteLine(printWord);

                Canvas.AddText(wrongGuesses, 20, 150, 50, 500, 50, Color.Red);


                if (wrongGuesses.Length == 1)
                {

                    Canvas.AddEllipse(372, 210, 20, 20, Color.White, 2, Color.White);
                }

                if (wrongGuesses.Length == 2)
                {
                    Canvas.AddEllipse(372, 210, 20, 20, Color.White, 2, Color.White);

                    Canvas.AddEllipse(362, 230, 40, 80, Color.White, 2, Color.White);
                }

                if (wrongGuesses.Length == 3)
                {
                    Point point5 = new Point();

                    point5.X = 340;
                    point5.Y = 270;

                    Canvas.AddLine(point5, 50, Math.PI / 4, Color.White, 5);

                    Canvas.AddEllipse(372, 210, 20, 20, Color.White, 2, Color.White);

                    Canvas.AddEllipse(362, 230, 40, 80, Color.White, 2, Color.White);
                }

                if (wrongGuesses.Length == 4)
                {
                    Point point6 = new Point();

                    point6.X = 425;
                    point6.Y = 270;

                    Canvas.AddLine(point6, 50, Math.PI * 1.75, Color.White, 5);

                    Point point5 = new Point();

                    point5.X = 340;
                    point5.Y = 270;

                    Canvas.AddLine(point5, 50, Math.PI / 4, Color.White, 5);

                    Canvas.AddEllipse(372, 210, 20, 20, Color.White, 2, Color.White);

                    Canvas.AddEllipse(362, 230, 40, 80, Color.White, 2, Color.White);

                }

                if (wrongGuesses.Length == 5)
                {
                    Point point7 = new Point();

                    point7.X = 425;
                    point7.Y = 340;
                    Canvas.AddLine(point7, 50, Math.PI * 1.75, Color.White, 5);
                    Point point6 = new Point();

                    point6.X = 425;
                    point6.Y = 270;
                    Canvas.AddLine(point6, 50, Math.PI * 1.75, Color.White, 5);
                    Point point5 = new Point();

                    point5.X = 340;
                    point5.Y = 270;
                    Canvas.AddLine(point5, 50, Math.PI / 4, Color.White, 5);
                    Canvas.AddEllipse(372, 210, 20, 20, Color.White, 2, Color.White);

                    Canvas.AddEllipse(362, 230, 40, 80, Color.White, 2, Color.White);

                }

                if (wrongGuesses.Length == 6)
                {
                    Point point8 = new Point();

                    point8.X = 335;
                    point8.Y = 340;
                    Canvas.AddLine(point8, 50, Math.PI / 4, Color.White, 5);

                    Point point7 = new Point();

                    point7.X = 425;
                    point7.Y = 340;
                    Canvas.AddLine(point7, 50, Math.PI * 1.75, Color.White, 5);

                    Point point6 = new Point();

                    point6.X = 425;
                    point6.Y = 270;

                    Canvas.AddLine(point6, 50, Math.PI * 1.75, Color.White, 5);
                    Point point5 = new Point();

                    point5.X = 340;
                    point5.Y = 270;

                    Canvas.AddLine(point5, 50, Math.PI / 4, Color.White, 5);
                    Canvas.AddEllipse(372, 210, 20, 20, Color.White, 2, Color.White);

                    Canvas.AddEllipse(362, 230, 40, 80, Color.White, 2, Color.White);

                    Canvas.AddText("You Lose!", 100, 100, 300, 700, 100, Color.Gray);

                    break;

                }
                
                if (winCount == word2.Length)
                {
                    Console.WriteLine("you win");

                    Canvas.AddText("You Win!", 100, 100, 300, 700, 100, Color.Gray);

                    break;
                }






            }


        }


    }
}     

