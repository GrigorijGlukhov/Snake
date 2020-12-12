using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {
        }

        // Accept coords
        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        // Accept Point
        public Point(Point _p)
        {
            x = _p.x;
            y = _p.y;
            sym = _p.sym;
        }

        public void Move(int _offset, Direction _direction)
        {
            if (_direction == Direction.RIGHT)
                x += _offset;
            if (_direction == Direction.LEFT)
                x -= _offset;
            if (_direction == Direction.UP)
                y -= _offset;
            if (_direction == Direction.DOWN)
                y += _offset;
        }

        // Draw char in positions x and y
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        // Debug method for Debuger
        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
