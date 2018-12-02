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
            Move(p1, 10, 10);
            Console.WriteLine("Call Move. p1.x = " + p1.x + ", p1.y = " + p1.y);
            /*Инкапсуляция - данные и методы объеденены в класс и детали реализации
             * скрыты от пользователя этого класса*/

            Point p2 = new Point(4,5,'#');
            p1 = p2; /*p1 указывает на адрес кучи, содержащийся в p2*/
            p2.x = 8;
            p2.y = 8;
            /*Изменяем данные в p2 и данные для p1 тоже изменяются, т.к. обе переменных указывают на одно место в памяти (в куче)*/
            Console.WriteLine("p1 = p2. p1.x = " + p1.x + ", p1.y = " + p1.y + "; p2.x = " + p2.x + ", p2.y = " + p2.y);

            p1 = new Point(1, 3, '*');
            Update(p1);
            Console.WriteLine("Call Update. p1.x = " + p1.x + ", p1.y = " + p1.y+"\n");

            /*----------------------------------------------*/
            int x = 1;
            Func1(x);
            Console.WriteLine("Call Func1. x = " + x);

            x = 1;
            Func2(x);
            Console.WriteLine("Call Func2. x = " + x);

            x = 1;
            Func3(x);
            Console.WriteLine("Call Func3. x = " + x);
            /*-------------------------------------------*/

            Console.ReadLine();
        }
        public static void Func1(int value)
        {
            /*В области "Стек" оперативной памяти создаётся переменная value, которая хранит вошедшее в функцию значение*/
        }

        public static void Func2(int value)
        {
            /*Меняется значение внутренней переменной, значение поступившей переменной не изменится*/
            value = value + 1;
        }

        public static void Func3(int x)
        {
            /*Меняется значение внутренней переменной, значение поступившей переменной не изменится (даже если она называется так же)*/
            x = x + 1;
        }

        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y + dy;
        }

        public static void Update(Point p)
        {
            /*Создаётся новая переменная p, которая указывает на новый адрес в куче, в котором лежит "пустая" точка*/
            p = new Point();
        }
    }
}
