using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class Polygon
    {
        public static string type;
        public List<Point> points;

        public Polygon (Point a, Point b, Point c)
        {
            type = "треугольник";
            points = new List<Point>() { a, b, c };
        }

        public Polygon(Point a, Point b, Point c, Point d)
        {
            type = "четырехугольник";
            points = new List<Point>() { a, b, c, d };
        }

        public Polygon(Point a, Point b, Point c, Point d, Point e)
        {
            type = "пятиугольник";
            points = new List<Point>() { a, b, c, d, e };
        }

        public int Perimeter()
        {
            try
            {
                int perimeter = 0;
                for (int i = 0; i < points.Count - 1; i++)
                {
                    perimeter += LineLength(points[i], points[i + 1]);
                }
                perimeter += LineLength(points[^1], points[0]);

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
            Console.WriteLine($"Многоугольник типа {type} состоит из следующих точек: ");
            foreach (var point in points)
            {
                Console.WriteLine($"Точка {point.Name} c координатами ({point.X},{point.Y})");
            }
        }
    }
}
