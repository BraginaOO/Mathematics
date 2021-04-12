using System;

namespace Mathematics3D
{
    public class Ball : Shape
    {
        private string _name;
        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double R;
        public Ball(double radius)
        {
            R = radius;
            _name = "шар";
        }
        public override double Volume()
        {
            try
            {
                double result = 4 * Math.PI * Math.Pow(R, 2) / 3;
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
            Console.WriteLine($"Фигура {_name} радиусом {R} имеет объем {Volume()}");
        }
    }
}
