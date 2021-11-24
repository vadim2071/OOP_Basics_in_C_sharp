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

        public int Radius { get { return this._radius; } set { this._radius = value; } }
        public Circle(color color, bool visible, int x, int y, int radius) : base(color, visible, x, y)
        {
            _x = x;
            _y = y;
            _radius = radius;
        }

        public float SquareCircle() //Метод вычисления площади круга
        {
            return (float)(3.14 * _radius * _radius);
        }
    }
}
