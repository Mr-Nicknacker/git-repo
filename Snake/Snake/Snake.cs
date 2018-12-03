using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Абстрагирование - способ выделить набор значимых характеристик объекта, изучая из рассмотрения незначимые*/
/*Важно:
 - Змейка - некоторая фигура на карте;
 - состоит из точек
 - стартовая позиция змейки на карте
 - конкретное направление*/
namespace Snake
{
    class Snake : Figure
    {
        public Snake(Point tail, int length, Direction direction)
        {
            pList = new List<Point>();
            for (int i=0; i< length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
    }
}
