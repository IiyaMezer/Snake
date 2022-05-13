using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Ver_line
    {
        List<point> plist;

        public Ver_line(int yH, int yL, int x, char sym)
        {
            plist = new List<point>();

            for (int y = yH; y <= yL; y++)
            {
                point p = new point(x, y, sym);
                plist.Add(p);
            }


        }

        public void Draw()
        {
            foreach (point p in plist)
            {
                p.Draw();
            }
        }
    }
}
