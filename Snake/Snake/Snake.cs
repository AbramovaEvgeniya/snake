using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        

        public Snake(Point tail, int lenght, Direction direction)
        {
            pList = new List<Point>();
           
            for (int i = 0; i < lenght; i++) //первый виток цикла - хвостовая точка будет сдвинута на 0, на втором - 1, и т.д
            {
                Point p = new Point(tail); //создание точки хвоста
                p.Move(i, direction); //сдвиг созданной точки на i позиций по направлению Direction
                pList.Add(p); // добавление этой точки в список
            }
        }
    }
}
