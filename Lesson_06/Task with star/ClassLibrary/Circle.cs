using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Circle : Point
    {
        private int _x; // координаты x
        private int _y; // координата y
        private int _radius; // радиус
        public Circle(color color, bool visible, int x, int y, int radius) : base(color, visible, x, y)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public float SquareCircle()
        {
            return (float)(3.14 * _radius * _radius);
        }
    }
}
