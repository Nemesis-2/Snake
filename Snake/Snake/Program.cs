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

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> qList = new List<Point>();
            qList.Add(q1);
            qList.Add(q2);

            Console.ReadLine();
        }

    }
}
