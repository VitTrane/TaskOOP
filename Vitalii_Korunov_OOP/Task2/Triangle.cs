using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Triangle
    {
        private int _a;
        private int _b;
        private int _c;

        public int A 
        {
            get { return _a; }
        }

        public int B
        {
            get { return _b; }
        }

        public int C
        {
            get { return _c; }
        }

        public int Perimeter 
        {
            get { return _a + _b + _c; }
        }

        public double Area 
        {
            get 
            {
                double p = (_a + _b + _c) / 2.0;
                double area = Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
                return area;
            }
        }

        public Triangle(int a,int b,int c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
    }
}
