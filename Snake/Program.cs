using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Program
	{
		static void Main( string[] args )
		{
            Point lefttop = new Point(1, 1, ' ');
            Point rightbottom = new Point(79, 25, ' ');

            char sym = '*';




            Horizontalline topline = new Horizontalline(lefttop.x, rightbottom.x, lefttop.y, sym);
            topline.Draw();

            Horizontalline bottomline = new Horizontalline(lefttop.x, rightbottom.x, rightbottom.y, sym);
            bottomline.Draw();

            Verticalline leftline = new Verticalline(lefttop.x, lefttop.y++, rightbottom.y--, sym);
            leftline.Draw();

            Verticalline rightline = new Verticalline(rightbottom.x, lefttop.y++, rightbottom.y--, sym);
            rightline.Draw();

            //Draw(1, 3, '*');
            //Draw(3, 5, '#');

            Console.ReadLine();
		}

        static void Draw(int x, int y, char sym){
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
	}
}
