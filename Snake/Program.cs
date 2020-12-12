using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false; // Hide cursor in console

            // Border draw
            HorizontalLine topLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, 24, '+');
            VerticalLine rightLine = new VerticalLine(78, 0, 24, '+');
            topLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            // Point draw
            Point p = new Point(4, 5, '*');
            p.Draw();


            Console.ReadLine();
        } 
    }
}
