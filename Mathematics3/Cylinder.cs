using System;

namespace Mathematics3D
{
    public class Cylinder : Shape
    {
        private string _name;
        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double R;
        public double H;
        public Cylinder(double baseRadius, double height)
        {
            R = baseRadius;
            H = height;
            _name = "цилиндр";
        }

        public override double Volume()
        {
            try
            {
                double result = Math.PI * Math.Pow(R, 2) * H;
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
            Console.WriteLine($"Фигура {_name} с радиусом основания {R} и высотой {H} имеет объем {Volume()}\n");
        }
    }
}
