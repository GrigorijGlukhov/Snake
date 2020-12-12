﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int _xLeft, int _xRight, int _y, char _sym)
        {
            pList = new List<Point>();
            for (int x = _xLeft; x <= _xRight; x++)
            {
                Point p = new Point(x, _y, _sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}