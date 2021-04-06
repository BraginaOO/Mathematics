using System;

namespace Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация работы программы Расчет периметра многоугольника:");
            //создание точек и вывод информации о них
            Point a = new Point("A", 1, 3);
            Point b = new Point("B", 1, 1);
            Point c = new Point("C", 3, 1);
            Point d = new Point("D", 3, 3);
            Point e = new Point("E", 2, 5);
            Console.WriteLine("Создано 5 точек: ");
            a.DisplayInfo();
            b.DisplayInfo();
            c.DisplayInfo();
            d.DisplayInfo();
            e.DisplayInfo();
            // создание полигонов и вывод информации о них
            Polygon triangle = new Polygon(a, b, c);
            Polygon quadrangle = new Polygon(a, b, c, d);
            Polygon pentagon = new Polygon(a, b, c, d, e);
            Console.WriteLine("Создано три вида многоугольников:");
            triangle.DisplayInfo();
            quadrangle.DisplayInfo();
            pentagon.DisplayInfo();
            // расчет периметра всех созданных многоугольников
            Console.WriteLine("Расчет периметра многоугольников:");
            Console.WriteLine($"Периметр треугольника: {triangle.Perimeter()}");
            Console.WriteLine($"Периметр четырехугольник: {quadrangle.Perimeter()}");
            Console.WriteLine($"Периметр пятиугольника: {pentagon.Perimeter()}");


        }
    }
}
