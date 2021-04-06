using System;

namespace Mathematics
{
    public class Point
    {
        public string Name { get; }
        public int X { get; }
        public int Y { get;  }

        public Point(string pointName, int pointX, int pointY)
        {
            Name = pointName;
            X = pointX;
            Y = pointY;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Точка {Name} имеет координаты: {X} по оси X и {Y} по оси Y");
        }
    }
}
