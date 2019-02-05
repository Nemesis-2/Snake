using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {

            HorizontalLine Upline = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine Downline = new HorizontalLine(0, 78, 24, '+');
            VerticalLine Rightline = new VerticalLine(0, 24, 0, '-');
            VerticalLine Leftline = new VerticalLine(0, 24, 78, '-');
            Rightline.Drow();
            Leftline.Drow();
            Upline.Drow();
            Downline.Drow();

            Point q = new Point(4, 5, '*');
            Snake snake = new Snake(q, 4, Direction.RIGHT);
            snake.Drow();

            Console.ReadLine();
        }

    }
}
