using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public abstract class Shape : IDraw
    {
        private int _x;
        private int _y;

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public Shape(int x = 0, int y = 0)
        {
            _x = x;
            _y = y;
        }

        public virtual void Draw()
        {
            Console.WriteLine(this.GetType().Name + " координаты: ({0},{1})", _x, _y);
        }
    }
}
