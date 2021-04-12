using System;

namespace Mathematics3D
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Демонстрация работы программы Трехмерные фигуры");
            Box box = new Box(10);
            Shape ball = new Ball(10);
            Shape cylinder = new Cylinder(5, 10);
            Shape piramid = new Pyramid(7, 15);
            Console.WriteLine("Созданы следующие фигуры:");
            box.DisplayInfo();
            ball.DisplayInfo();
            cylinder.DisplayInfo();
            piramid.DisplayInfo();
            Console.WriteLine();
            if (box.Add(ball)) { box.DisplayConteinerInfo(); }
            if (box.Add(cylinder)) { box.DisplayConteinerInfo(); }
            if (box.Add(piramid)) { box.DisplayConteinerInfo(); }

        }
    }
}