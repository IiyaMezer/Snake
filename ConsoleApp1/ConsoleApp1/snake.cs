using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : figure
    {
        direction direction;
        public Snake (point tail, int lenght, direction _direction)
        {
            direction = _direction;
            plist = new List<point> ();
            for(int i = 0; i < lenght; i++)
            {
                point p = new point (tail);
                p.Move(i, direction);
                plist.Add (p);
            }
       

        }

        internal void Move()
        {
            point tail = plist.First ();
            plist.Remove (tail);
            point head = GetNextPoint();
            plist.Add(head);

            tail.Clear();
            head.Draw ();
        }
        public point GetNextPoint()
        {
            point head = plist.First ();
            point nextpoint = new point (head);
            nextpoint.Move(1, direction);
            return nextpoint;
        }
    }
}
