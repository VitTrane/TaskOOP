using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Circle : Round
    {
        public Circle()
            :base()
        {
        }

        public Circle(int x, int y, int radius=5)
            : base(x, y,radius)
        {
        }
    }
}
