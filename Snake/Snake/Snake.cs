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
        Direction direction; //если добавить public - дали доступ к переменной остальным подпрограммам

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

        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food)) //Если змейка наступила на еду (если координаты нового шага змейки равны координатам, где лежит еда
            {
                food.sym = head.sym;
                pList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }

        //Генерируем точку, следующую после головы в заданном направлении (двигаем змейку)
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        //Изменение направления змейки по нажатию клавиши
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
            else if (key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
        }
    }
}
