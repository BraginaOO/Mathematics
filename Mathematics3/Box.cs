using System;
using System.Collections.Generic;

namespace Mathematics3D
{
    public class Box : Shape
    {
        private string _name;
        public override string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double H;
        public List<Shape> conteinerContent;

        public Box(double height)
        {
            H = height;
            _name = "куб";
            conteinerContent = new List<Shape>();
        }
        public override double Volume()
        {
            try
            {
                double result = Math.Pow(H, 3);
                return result;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Вычисление объема завершилось ошибкой {exception}, объему присвоено автоматически значение 0");
                return 0;
            }
        }

        public bool Add(Shape shape)
        {
            if ((this.Volume() - this.FilledVolume()) > shape.Volume())
            {
                conteinerContent.Add(shape);
                Console.WriteLine($"Фигура {shape.Name} объемом {shape.Volume()} помещена в контейнер.");
                return true;
            }
            else
            {
                Console.WriteLine($"Фигура {shape.Name} объемом {shape.Volume()} не может быть помещена в контейнер. Контейнер объемом {this.Volume()} заполнен на {this.FilledVolume()}");
                return false;
            }
        }

        private double FilledVolume()
        {
            double v = 0;
            foreach (Shape element in conteinerContent)
            {
                v += element.Volume();
            }
            return v;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Фигура {_name} с высотой ребра {H} имеет объем {Volume()}");
        }

        public void DisplayConteinerInfo()
        {
            Console.WriteLine($"Контейнер объемом {Volume()} заполнен на {FilledVolume()}. В контейнер помещены следующие фигуры:");
            foreach (Shape element in conteinerContent)
            {
                element.DisplayInfo();
            }
            Console.WriteLine();
        }
    }
}
