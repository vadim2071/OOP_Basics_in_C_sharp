using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Archers : BaseUnit //лучник
    {
        private int _distanceAttack; //Дистанция атаки луком
        public Archers(int x, int y) : base(x,y)
        {
            _armor = 100;
            _attack = 50;
            _health = 80;
            _maxStep = 3;
            _x = x;
            _y = y;
            _distanceAttack = 5;
        }

        public override int Impact()
        {
            return 20*5;
        }

    }
}
