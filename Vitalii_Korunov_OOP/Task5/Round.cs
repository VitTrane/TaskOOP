using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Round : Shape
    {
        private int _radius;

        public int Radius
        {
            get { return _radius; }
            set 
            {
                if (value > 0)
                    _radius = value;
                else
                    _radius = 0;
            }
        }

        public double Length
        {
            get { return CalculateLength(); }
        }

        public double Area
        {
            get { return CalculateArea(); }
        }

        public Round(int radius = 5)
            : base()
        {
            _radius = radius;
        }

        public Round(int x, int y, int radius = 5)
            : base(x, y)
        {
            _radius = radius;
        }

        protected virtual double CalculateArea() 
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        protected virtual double CalculateLength() 
        {
            return 2 * Math.PI * _radius;
        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Радиус: " + _radius);
            Console.WriteLine("Длина: {0:0.##}", Length);
            Console.WriteLine("Площадь: {0:0.##}", Area);
        }
    }
}
