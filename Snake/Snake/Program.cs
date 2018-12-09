using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
/*Полиморфизм*/
            VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
            Draw(v1); //т.к. вертикальная линия ещё и фигура, функция, принимающая фигуру, сработает

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Direction.RIGHT); //fSnake рассматривается как фигура и методы класса Snake работать не будут
            Draw(fSnake);
            Snake snake = (Snake)fSnake;//Явное приведение типа - конвертирует фигуру fSnake в элемент класса Snake

            HorizontalLine h1 = new HorizontalLine(0, 5, 6, '&');

            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(v1);
            figures.Add(h1);
            //Список фигур может хранить все эти элементы, т.к. они являются ещё и фигурами

            foreach (var f in figures)
            {
                f.Draw();/*у всех наследников класса фигуры есть этот метод. Метод можно изменить для какой-то конкретной фигуры*/
            }
            Console.ReadLine();

        }
        static void Draw (Figure figure)
        {
            figure.Draw();
        }
    }
}
