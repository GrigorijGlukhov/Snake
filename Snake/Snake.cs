using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction; // Current direction of snake 

        public Snake (Point _tail, int _length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i=0; i< _length; i++)
            {
                Point p = new Point(_tail);
                p.Move(i, _direction); // Offset tail point in Direction
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
