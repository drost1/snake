using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Verticalline : Figure
    {
        public Verticalline(int x, int y_top, int y_bottom, char sym)
        {
            pList = new List<Point>();
            for ( int i = y_top; i <= y_bottom; i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);
            }
        }
    }
}
