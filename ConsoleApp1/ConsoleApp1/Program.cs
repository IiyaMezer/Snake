using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {           

            hor_line Upline = new hor_line(0, 78, 0, '+');
            hor_line Downline = new hor_line(0, 78, 24, '+');
            Ver_line Leftline = new Ver_line(0, 24, 0, '+');
            Ver_line Rline = new Ver_line(0, 24, 78, '+');
            Upline.Draw();
            Downline.Draw();
            Leftline.Draw();
            Rline.Draw();

            point p = new point(4, 5, '*');


            Snake snake = new Snake(p, 4, direction.right);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.ControlKey( key.Key);
                }
                

             
                Thread.Sleep(100);
                snake.Move();
            }




            
        }

    
    }
}
