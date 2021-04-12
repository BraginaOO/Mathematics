using System;

namespace Mathematics3D
{
    public class Pyramid : Shape
    {
        private string _name;
        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double S;
        public double H;
        public Pyramid(double baseSquare, double height)
        {
            S = baseSquare;
            H = height;
            _name = "пирамида";
        }

        public override double Volume()
        {
            try
            {
                double result = S * H / 3;
                return result;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Вычисление объема завершилось ошибкой {exception}, объему присвоено автоматически значение 0");
                return 0;
            }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Фигура {_name} с площадью основания {S} и высотой {H} имеет объем {Volume()}\n");
        }
    }
}
