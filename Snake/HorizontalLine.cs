using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int _xLeft, int _xRight, int _y, char _sym)
        {
            pList = new List<Point>();
            for (int x = _xLeft; x <= _xRight; x++)
            {
                Point p = new Point(x, _y, _sym);
                pList.Add(p);
            }
        }

        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach(Point p in pList)
            {
                p.Draw();
            }
            // or call base class's method -> base.Draw(); // because it's same implementation
            // base.Draw();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
