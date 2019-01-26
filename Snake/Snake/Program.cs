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
            Point q1 = new Point();
            q1.x = 1;
            q1.y = 3;
            q1.sym = '*';
            q1.Draw();

            Point q2 = new Point();
            q2.x = 4;
            q2.y = 7;
            q2.sym = '#';
            q2.Draw();

            Console.ReadLine();
        }

    }
}
