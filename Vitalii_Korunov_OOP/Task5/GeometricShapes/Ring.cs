using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Ring : Circle
    {
        private int _width;
        private int _internalRadius;

        public int InternalRadius
        {
            get { return _internalRadius; }
        }

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

        public Ring()
            :base()
        {
        }

        public Ring(int x, int y, int radius = 5,int width=2)
            : base(x, y,radius)
        {
            _width = width;
            CalculateInternalRadius(radius);
        }

        private void CalculateInternalRadius(int radius) 
        {
            if (!(radius - _width < 0))
                _internalRadius = radius - _width;
            else
                _internalRadius = 0;
        }

        protected override double CalculateArea()
        {
            return Math.PI * (Math.Pow(Radius, 2) - Math.Pow(InternalRadius, 2));
        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Ширина: " + Width);
        }
    }
}
