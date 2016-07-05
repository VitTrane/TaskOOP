using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Round
    {
        private int _x;
        private int _y;
        private int _radius;        

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int Radius
        {
            get { return _radius; }
        }

        public double Length
        {
            get { return 2 * Math.PI * _radius; }
        }

        public double Area 
        {
            get { return Math.PI * Math.Pow(_radius,2); }
        }

        public Round(int x,int y,int radius)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }
    }
}
