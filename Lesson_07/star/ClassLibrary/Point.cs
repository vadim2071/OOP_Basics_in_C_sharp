using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Point : Figure
    {
        private int _x; // координаты x
        private int _y; // координата y
        public int X { get { return this._x; } set { this._x = value; } }
        public int Y { get { return this._y; } set { this._y = value; } }
        public Point(color color, bool visible, int x, int y) : base(color, visible)
        {
            _x = x;
            _y = y;
        }


        public override void Move(move _move, int _step) //метод движения фигуры
        {
            switch (_move)
            {
                case move.left:
                    _x = _x - _step;
                    break;
                case move.right:
                    _x = _x + _step;
                    break;
                case move.up:
                    _y = _y + _step;
                    break;
                case move.down:
                    _y = _y - _step;
                    break;
            }
        }
    }
}
