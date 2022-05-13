using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class hor_line
    {
        List<point> plist;

        public hor_line(int xL, int xR, int y, char sym)
        {
            plist = new List<point>();

            for(int x = xL; x <= xR; x++)
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
