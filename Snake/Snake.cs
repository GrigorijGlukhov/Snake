using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Snake (Point _tail, int _length, Direction _direction)
        {
            pList = new List<Point>();
            for (int i=0; i< _length; i++)
            {
                Point p = new Point(_tail);
                p.Move(i, _direction); // Offset tail point in Direction
                pList.Add(p);
            }
        }
    }
}
