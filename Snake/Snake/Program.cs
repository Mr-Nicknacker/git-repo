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
            Console.SetBufferSize(80, 25); /*Устанавливает размер окна*/

/*Наследование - св-во системы, позволяющее описать новый класс на основе уже существующего с частично или полностью замещающейся функциональностью*/
            //Создаём рамку
            HorizontalLine topLine = new HorizontalLine(0, 78, 0,'+');
            HorizontalLine botLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');

            //Рисуем рамку
            topLine.Draw();
            botLine.Draw();            
            leftLine.Draw();            
            rightLine.Draw();

            Console.ReadLine();
        }
    }
}
