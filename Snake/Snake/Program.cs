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
            Point q1 = new Point(1, 3, '*');
            q1.Draw();

            Point q2 = new Point(4, 5, '#');
            q2.Draw();

            Console.ReadLine();
        }

    }
}
