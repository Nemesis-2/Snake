using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {

        public HorizontalLine(int xLeft,int xRhigt, int y, char sym)
        {
            qList = new List<Point>();
            for(int x = xLeft; x <= xRhigt; x++)
            {
                Point q = new Point(x, y, sym);
                qList.Add(q);
            }
        }

    }
}
