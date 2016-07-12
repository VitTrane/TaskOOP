using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Line : Shape
    {
        private int DEFAULT_END_POINT_X = 0;
        private int DEFAULT_END_POINT_Y = 0;

        private int _endPointX;
        private int _endPointY;

        public Line() 
            : base()
        {
            _endPointX = DEFAULT_END_POINT_X;
            _endPointY = DEFAULT_END_POINT_Y;
        }

        public Line(int x,int y,int endPointX, int endPointY)
            : base(x,y)
        {
            _endPointX = endPointX;
            _endPointY = endPointY;
        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Конечные координаты: ({0},{1})", _endPointX, _endPointY);
        }
    }
}
