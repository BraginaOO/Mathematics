using System;
using System.Collections.Generic;

namespace Mathematics2D
{
    public class Polygon
    {
        public string Type = "многоугольник";
        public List<Point> Points;

        public Polygon (Point a, Point b, Point c)
        {
            Type = "треугольник";
            Points = new List<Point>() { a, b, c };
        }

        public Polygon(Point a, Point b, Point c, Point d)
        {
            Type = "четырехугольник";
            Points = new List<Point>() { a, b, c, d };
        }

        public Polygon(Point a, Point b, Point c, Point d, Point e)
        {
            Type = "пятиугольник";
            Points = new List<Point>() { a, b, c, d, e };
        }

        public int Perimeter()
        {
            try
            {
                int perimeter = 0;
                for (int i = 0; i < Points.Count - 1; i++)
                {
                    perimeter += LineLength(Points[i], Points[i + 1]);
                }
                perimeter += LineLength(Points[^1], Points[0]);

                return perimeter;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Вычисление периметра завершилось ошибкой {exception}, периметру присвоено автоматически значение 0");
                return 0;
            }
            
        }

        private static int LineLength(Point firstPoint, Point secondPoint)
        {
            try
            {
                int result = (int) Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2));
                return result;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Вычисление длины отрезка {firstPoint.Name}{secondPoint.Name} завершилось ошибкой {exception}, длина отрезка сброшена на 0");
                return 0;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Многоугольник типа {Type} состоит из следующих точек: ");
            foreach (var point in Points)
            {
                Console.WriteLine($"Точка {point.Name} c координатами ({point.X},{point.Y})");
            }
        }
    }
}
