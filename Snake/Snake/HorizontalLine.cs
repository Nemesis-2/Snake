using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> qList;

        public HorizontalLine(int xLeft,int yRhigt, int y, char sym)
        {
            qList = new List<Point>();
            for(int x = xLeft; x <= yRhigt; x++)
            {
                Point q = new Point(x, y, sym);
                qList.Add(q);
            }
        }

        public void Drow()
        {
            foreach (Point q in qList)
            {
                q.Draw();
            }
        }
    }
}
