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
            int px = 0;
            int py = 0;

            Point p1 = new Point(1,3,'*');
            p1.Draw();
            
            Point p2 = new Point(4,5,'#');
            p2.Draw();

            /*-----------------LIST------------------------*/
            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0]; /*В x передаём значение первого элемента списка*/
            int y = numList[1]; /*В y передаём значение второго элемента списка*/
            int z = numList[2];

            foreach(int i in numList)
            {
                Console.WriteLine("\n"+i);
            }

            numList.RemoveAt(0); /*Удалить элемент с порядковым номером 0 из списка*/

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
                        
            /*Домашняя работа*/
            /*Инициализирую список символов*/
            List<char> symList = new List<char>();
            symList.Add('*');
            symList.Add('#');
            symList.Add('$');
            symList.Add('%');

            Console.Clear();

            /*Инициализирую список точек*/
            Console.WriteLine("Сколько точек нужно создать?");
            int n = Convert.ToInt32( Console.ReadLine());
            List<Point> _pList = new List<Point>();

            for (int i = 0; i<n; i++)
            {
                Point p = new Point(1+px, 3+py, symList[i]);
                px++;py++;
                _pList.Add(p);
            }

            foreach (Point pnt in _pList)
            {
                pnt.Draw();
            }

            Console.ReadLine();
        }
    }
}
