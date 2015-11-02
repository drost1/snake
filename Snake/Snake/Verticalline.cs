using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Verticalline
    {
        List<Point> pList = new List<Point>();
        public Verticalline(int x, int y_top, int y_bottom, char sym)
        {
            Point p;
            for( int i = y_top; i <= y_bottom; i++)
            {
                p = new Point(x, i, sym);
                pList.Add(p);
            }
        }


        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
