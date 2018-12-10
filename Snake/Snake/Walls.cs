using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList; 

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            //Создаём рамку
            HorizontalLine topLine = new HorizontalLine(0, mapWidth-2, 0, '+');
            HorizontalLine botLine = new HorizontalLine(0, mapWidth-2, mapHeight-1, '+');
            VerticalLine leftLine = new VerticalLine(0, mapHeight-1, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, mapHeight-1, mapWidth-2, '+');

            //в список фигур (базовый класс) добавляем объекты наследников
            wallList.Add(topLine);
            wallList.Add(botLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit (Figure figure)
        {
            foreach(var wall in wallList) //wall - фигура
            {
                if (wall.IsHit(figure)) //метод IsHit для фигуры wall
                {
                    return true;
                }
            }
            return false;
        }
        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }
    }
}
