using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Rectangle : Shape
    {
        private int _width;
        private int _length; 

        public int Width
        {
            get { return _width; }
            set 
            {
                if (value > 0)
                    _width = value;
                else
                    _width = 0;
            }
        }

        public int Length
        {
            get { return _length; }
            set 
            {
                if (value > 0)
                    _length = value;
                else
                    _length = 0;
            }
        }

        public double Area
        {
            get { return _width * _length; }
        }

        public int Perimeter 
        {
            get { return 2 * (_length + _width); }
        }

        public Rectangle(int x, int y, int width=5, int length=5)
            : base(x,y)
        {
            _width = width;
            _length = length;
        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Длина:" + _length);
            Console.WriteLine("Ширина:" + _width);
            Console.WriteLine("Периметр: " + Perimeter);
            Console.WriteLine("Площадь:{0:0.##}", Area);
        }
    }
}
