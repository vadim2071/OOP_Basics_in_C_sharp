using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Circle : Point
    {
        private int _radius; // радиус

        public int Radius { get { return this._radius; } set { this._radius = value; } }
        public Circle(color color, bool visible, int x, int y, int radius) : base(color, visible, x, y)
        {
            X = x;
            Y = y;
            _radius = radius;
        }

        public float SquareCircle() //Метод вычисления площади круга
        {
            return (float)(3.14 * _radius * _radius);
        }
    }
}
