using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class figure
    {
       protected List<point> plist;

        public void Draw()
        {
            foreach (point p in plist)
            {
                p.Draw();
            }
        }
    }
}