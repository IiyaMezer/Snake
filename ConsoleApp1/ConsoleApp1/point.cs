﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class point
    {
        public int x;
        public int y;
        public char sym;

       public point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;        
        }

        public point(point p)
        {
            x=p.x;
            y=p.y;
            sym = p.sym;
        }

        public void Move(int offset, direction direction)
        {
            if (direction == direction.right)
            {
                x=x+offset;
            }
            else if (direction == direction.left)
            {
                x=x-offset;
            }
            //else (direction == direction.top)
            //{
            //    y=y+offset;
            //}
            //else (direction == direction.dowwn)
            //{
            //    y = y - offset;
            //}
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
