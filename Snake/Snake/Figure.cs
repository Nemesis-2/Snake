using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> qList;

        public void Drow()
        {
            foreach (Point q in qList)
            {
                q.Draw();
            }
        }
    }
}
