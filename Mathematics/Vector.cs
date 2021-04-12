using System;

namespace Mathematics2D
{
    public class Vector
    {
        public string Name;
        public double X;
        public double Y;
        public double Z;


        public Vector(string name, double x, double y, double z)
        {
            Name = name;
            X = x;
            Y = y;
            Z = z;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Вектор {Name} имеет координаты: {X} по оси X, {Y} по оси Y, {Z} по оси Z");
        }

        public double VectorLength()
        {
            try
            {
                double result = Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
                return result;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Вычисление длины вектора {Name} завершилось ошибкой {exception}, длина вектора сброшена на 0");
                return 0;
            }
        }

        public static double VectorsScalar(Vector v1, Vector v2)
        {
            try
            {
                double result = (v1.X * v2.X) + (v1.Y * v2.Y) + (v1.Z * v2.Z);
                return result;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Вычисление скалярного произведения векторов {v1.Name} и {v2.Name} завершилось ошибкой {exception}, результат сброшен на 0");
                return 0;
            }
        }

        public static Vector VectorsProduct(Vector v1, Vector v2, string resultVectorName)
        {
            try
            {
                var productX = (v1.Y * v2.Z) - (v1.Z * v2.Y);
                var productY = (v1.Z * v2.X) - (v1.X * v2.Z);
                var productZ = (v1.X * v2.Y) - (v1.Y * v2.X);
                var result = new Vector(resultVectorName, productX, productY, productZ);
                return result;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Вычисление векторного произведения {v1.Name} и {v2.Name} завершилось ошибкой {exception}, результат не сохранен");
                return null;
            }
        }

        public static double VectorsAngle(Vector v1, Vector v2)
        {
            try
            {
                var result = VectorsScalar(v1, v2) / (Math.Abs(v1.VectorLength()) * Math.Abs(v2.VectorLength()));
                return result;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Вычисление угла (косинуса) между векторами {v1.Name} и {v2.Name} завершилось ошибкой {exception}, углу присвоено значение 0");
                return 0;
            }
        }

        public static Vector VectorsSum(Vector v1, Vector v2, string resultVectorName)
        {
            try
            {
                var productX = (v1.X + v2.X);
                var productY = (v1.Y + v2.Y);
                var productZ = (v1.Z + v2.Z);
                var result = new Vector(resultVectorName, productX, productY, productZ);
                return result;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Вычисление суммы векторов {v1.Name} и {v2.Name} завершилось ошибкой {exception}, результат не сохранен");
                return null;
            }
        }

        public static Vector VectorsSubtraction(Vector v1, Vector v2, string resultVectorName)
        {
            try
            {
                var productX = (v1.X - v2.X);
                var productY = (v1.Y - v2.Y);
                var productZ = (v1.Z - v2.Z);
                var result = new Vector(resultVectorName, productX, productY, productZ);
                return result;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Вычисление разности векторов {v1.Name} и {v2.Name} завершилось ошибкой {exception}, результат не сохранен");
                return null;
            }
        }
    }
}
