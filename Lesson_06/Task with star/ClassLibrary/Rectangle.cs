using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Rectangle : Point
    {

        private int _width; //длина стороны
        private int _height; //высота стороны
        public int Width { get { return this._width; } set { this._width = value; } }
        public int Height { get { return this._height; } set { this._height = value; } }

        public Rectangle(color color, bool visible, int x, int y, int width, int height) : base(color, visible, x, y)
        {
            X = x;
            Y = y;
            _width = width;
            _height = height;
        }
        public float SquareArea()
        {
            return (float)(_height * _width);
        }
    }
}
