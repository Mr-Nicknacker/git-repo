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

        public virtual void Draw() //Любой наследник может переопределить этот метод
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
