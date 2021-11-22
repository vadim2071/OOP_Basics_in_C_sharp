using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Rectangle : Point
    {
        private int _x; // координаты x
        private int _y; // координата y
        private int _radius; // радиус
        public Rectangle(color color, bool visible, int x, int y) : base(color, visible, x, y)
        {
        }
    }
}
