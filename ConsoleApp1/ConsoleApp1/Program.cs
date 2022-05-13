using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //int x1 = 1;
            //int y1 = 3;
            //char sym1 = '*';

            //Draw(x1, y1, sym1);

            //int x2 = 4;
            //int y2 = 5;
            //char sym2 = '#';
            //Draw(x2, y2, sym2);     Это первая вариация

            //point p1 = new point();
            //p1.x = 1;
            //p1.y = 3;
            //p1.sym = '*';
            //Draw(p1.x, p1.y, p1.sym);

            //point p2 = new point();
            //p2.x = 4;
            //p2.y = 5;
            //p2.sym = '#';
            //Draw(p2.x, p2.y, p2.sym);   Вариация через классы

            point p1 = new point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            p1.Draw();

            point p2 = new point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            p2.Draw();

            Console.ReadLine();
        }

    
    }
}
