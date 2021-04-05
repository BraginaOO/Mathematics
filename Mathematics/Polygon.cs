using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematics
{
    public class Polygon
    {
        public static string name;
        public List<Point> points;

        public Polygon (Point a, Point b, Point c)
        {
            name = "треугольник";
            points = new List<Point>() { a, b, c };
        }

        public Polygon(Point a, Point b, Point c, Point d)
        {
            name = "четырехугольник";
            points = new List<Point>() { a, b, c, d };
        }

        public Polygon(Point a, Point b, Point c, Point d, Point e)
        {
            name = "пятиугольник";
            points = new List<Point>() { a, b, c, d, e };
        }

        public static int Perimeter(List<Point> points)
        {
            int perimeter = 0;
            for (int i = 0; i < points.Count-1; i++)
            {
                perimeter += LineLength(points[i], points[i + 1]);
            }
            perimeter += LineLength(points[^1],points[0]);

            return perimeter;
        }

        private static int LineLength(Point firstPoint, Point secondPoint)
        {
            int result = (int)Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2));
            return result;
        }
    }
}
