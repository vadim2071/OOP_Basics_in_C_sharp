using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class BaseStructure //Защитное сооружение
    {
        private int _health; //здоровье
        private int _x; //положение строения
        private int _y;

        public int Health { get { return this._health; } set { this._health = value; } }
        public int X { get { return this._x; } set { this._health = value; } }
        public int Y { get { return this._y; } set { this._health = value; } }

        public BaseStructure(int health, int x, int y) 
        {
            _health = health;
            _x = x;
            _y = y;
        }
    }
}
