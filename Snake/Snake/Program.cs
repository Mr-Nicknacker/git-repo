using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Хочу при создании класса точки сразу задавать её вид и коортинады*/
            Point p1 = new Point(1,3,'*');
            p1.Draw();
            /*Инкапсуляция - данные и методы объеденены в класс и детали реализации
             * скрыты от пользователя этого класса*/
            Point p2 = new Point(4,5,'#');
            p2.Draw();
            
            Console.ReadLine();
        }
    }
}
