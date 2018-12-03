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
        Direction direction;

        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i=0; i< length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First(); //Выдаёт первый элемент списка
            pList.Remove(tail);//Удаляет первое упоминание tail из списка
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear(); //координаты tail, а символ меняем на ' '
            head.Draw();
        }

//Генерируем точку, следующую после головы в заданном направлении (двигаем змейку)
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
