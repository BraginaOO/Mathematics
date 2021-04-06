using System;

namespace Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Демонстрация работы программы Расчет периметра многоугольника:");
            //создание точек и вывод информации о них
            var a = new Point("A", 1, 3);
            var b = new Point("B", 1, 1);
            var c = new Point("C", 3, 1);
            var d = new Point("D", 3, 3);
            var e = new Point("E", 2, 5);
            Console.WriteLine("Создано 5 точек: ");
            a.DisplayInfo();
            b.DisplayInfo();
            c.DisplayInfo();
            d.DisplayInfo();
            e.DisplayInfo();
            // создание полигонов и вывод информации о них
            var triangle = new Polygon(a, b, c);
            var quadrangle = new Polygon(a, b, c, d);
            var pentagon = new Polygon(a, b, c, d, e);
            Console.WriteLine("Создано три вида многоугольников:");
            triangle.DisplayInfo();
            quadrangle.DisplayInfo();
            pentagon.DisplayInfo();
            // расчет периметра всех созданных многоугольников
            Console.WriteLine("Расчет периметра многоугольников:");
            Console.WriteLine($"Периметр треугольника: {triangle.Perimeter()}");
            Console.WriteLine($"Периметр четырехугольник: {quadrangle.Perimeter()}");
            Console.WriteLine($"Периметр пятиугольника: {pentagon.Perimeter()}");


            Console.WriteLine("Демонстрация работы программы Вектор:");
            //создание вектора и вывод информации о нем
            var vectorA = new Vector("a", 1, 2, 3);
            var vectorB = new Vector("b", 0, -1, 2);
            Console.WriteLine("Создано 2 вектора:");
            vectorA.DisplayInfo();
            vectorB.DisplayInfo();
            //демонстрация работы методов с векторами
            Console.WriteLine($"Длина вектора {vectorA.Name} равна {vectorA.VectorLength()}");
            Console.WriteLine($"Длина вектора {vectorB.Name} равна {vectorB.VectorLength()}");
            Console.WriteLine($"Скалярное произведение векторов равно {Vector.VectorsScalar(vectorA, vectorB)}");
            var vectorC = Vector.VectorsProduct(vectorA, vectorB, "C");
            Console.WriteLine($"Результатом векторного произведения данных векторов является вектор C:");
            vectorC.DisplayInfo();
            Console.WriteLine($"Угол между векторами {vectorA.Name} и {vectorB.Name} равен {Vector.VectorsAngle(vectorA, vectorB)}");
            var vectorD = Vector.VectorsSum(vectorA, vectorB, "D");
            Console.WriteLine($"Результатом суммы векторов {vectorA.Name} и {vectorB.Name} является вектор D:");
            vectorD.DisplayInfo();
            var vectorE = Vector.VectorsSubtraction(vectorA, vectorB, "E");
            Console.WriteLine($"Результатом разности векторов {vectorA.Name} и {vectorB.Name} является вектор E:");
            vectorE.DisplayInfo();


        }
    }
}
