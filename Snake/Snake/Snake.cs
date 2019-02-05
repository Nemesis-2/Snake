﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Snake(Point tail, int lenght, Direction direction)
        {
            qList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point q = new Point(tail);
                q.Move(i, direction);
                qList.Add(q);
            }
        }
    }
}