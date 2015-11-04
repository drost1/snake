using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Horizontalline : Figure
    {
        public Horizontalline(int x_left, int x_right, int y, char sym)
        {
            pList = new List<Point>();
            for(int i = x_left; i <= x_right; i++)
            {
                Point p = new Point(i, y, sym);
                pList.Add(p);
            }
        }
   }
}
