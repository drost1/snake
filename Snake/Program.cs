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
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            Point lefttop = new Point(1, 1, ' ');
            Point rightbottom = new Point(79, 23, ' ');

            // Рисуем рамочку
            char sym = '+';
            Horizontalline topline = new Horizontalline(lefttop.x, rightbottom.x, lefttop.y, sym);
            Horizontalline bottomline = new Horizontalline(lefttop.x, rightbottom.x, rightbottom.y, sym);
            Verticalline leftline = new Verticalline(lefttop.x, lefttop.y++, rightbottom.y--, sym);
            Verticalline rightline = new Verticalline(rightbottom.x, lefttop.y++, rightbottom.y--, sym);
            topline.Draw();
            bottomline.Draw();
            leftline.Draw();
            rightline.Draw();

            Point p = new Point(3, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);

            Draw(5, 3, '*');
            //Draw(3, 5, '#');

            Console.ReadLine();
		}

        static void Draw(int x, int y, char sym){
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
	}
}
