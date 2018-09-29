using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session14
{
    class Program
    {
        static void Main(string[] args)
        {
            //DrawTwoRowFlag(ConsoleColor.Blue, ConsoleColor.Yellow);
            //DrawTwoRowFlag(ConsoleColor.Blue, ConsoleColor.White);
            //DrawThreeRowFlag(ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Blue);
            DrawVerticalTricolor(leftColor: ConsoleColor.Blue, middleColor: ConsoleColor.White, rightColor: ConsoleColor.Yellow, width: 6, height: 4);
            DrawVerticalTricolor(ConsoleColor.Yellow, ConsoleColor.Blue, ConsoleColor.DarkYellow, height: 4, width: 9);
        }

        static void DrawHorizontalLine(ConsoleColor leftColor, ConsoleColor middleColor, ConsoleColor rightColor, int width)
        {
            Console.BackgroundColor = leftColor;
            for (int i = 0; i < width; i++)
            {
                Console.Write(" ");
            }

            Console.BackgroundColor = middleColor;
            for (int i = 0; i < width; i++)
            { 
                Console.Write(" ");
            }

            Console.BackgroundColor = rightColor;
            for (int i = 0; i < width; i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine();
        }

        static void DrawVerticalTricolor(ConsoleColor leftColor, ConsoleColor middleColor, ConsoleColor rightColor, int height, int width)
        {
            for (int i = 0; i < height; i++)
            {
                DrawHorizontalLine(leftColor, middleColor, rightColor, width);
            }
        }

        static void DrawTwoRowFlag(ConsoleColor topColor, ConsoleColor bottomColor)
        {
            DrawLine(topColor);
            DrawLine(topColor);
            DrawLine(bottomColor);
            DrawLine(bottomColor);
            Console.ResetColor();
            Console.WriteLine();
        }

        static void DrawThreeRowFlag(ConsoleColor topColor, ConsoleColor middleColor, ConsoleColor bottomColor)
        {
            DrawLine(topColor);
            DrawLine(topColor);
            DrawLine(middleColor);
            DrawLine(middleColor);
            DrawLine(bottomColor);
            DrawLine(bottomColor);
            Console.ResetColor();
            Console.WriteLine();
        }

        static void DrawLine(ConsoleColor color)
        {
            Console.BackgroundColor = color;
            Console.WriteLine("                    ");
        }
    }
}
