using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    /*Наследование - св-во системы, позволяющее описать новый класс на основе уже существующего с частично или полностью замещающейся функциональностью*/
    class Figure //Базовый класс для своих наследников
    {
        protected List<Point> pList; //идентификатор доступа. Даёт наследникам видеть переменную

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        /*полиморфизм на уровне методов*/
        internal bool IsHit(Figure figure)
        {
            foreach (var p in pList) //передан список точек линии, который генерируется при её создании
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach(var p in pList)//передал точку стенки и хочу узнать, врезалась ли змейка в стенку
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
        }
    }
}
