using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Point : Figure
    {
        public Point(color color, bool visible) : base(color, visible)
        {
        }
        private int _x; // координаты x
        private int _y; // координата y

        public override void MoveHorizont(int move)
        {

        }
    }
}
