﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int _x, int _yTop, int _yBottom, char _sym)
        {
            pList = new List<Point>();
            for (int y = _yTop; y <= _yBottom; y++ )
            {
                Point p = new Point(_x, y, _sym);
                pList.Add(p);
            }
        }
    }
}
