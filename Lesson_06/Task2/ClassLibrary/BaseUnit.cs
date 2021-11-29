using System;
//2) Реализовать библиотеку классов для игры RPG (не менее 10 классов),
//используя изученные правила наследования).
//Определить базовые классы для важных сущностей, использовать наследование конструкторов,
//переопределение методов и расширение функционала для различных классов.

//Реализовать простую логику взаимодействия объектов между собой.
//Реализовать объект наблюдатель, который с заданной периодичностью будет собирать
//данные от всех созданных объектов на данный момент и записывать ее в лог.

namespace ClassLibrary
{
    public class BaseUnit
    {
        protected int _armor; //Броня
        protected int _attack; //Сила атаки
        protected int _health; //здоровье
        protected int _maxStep; //максимальный шаг передвижения
        protected int _x; //положение юнита
        protected int _y;

        public int Armor { get { return this._armor; } set { this._armor = value; } }
        public int Attack { get { return this._attack; } }
        public int Health { get { return this._health; } set { this._health = value; } }
        public int MaxStep { get { return this._maxStep; } }
        public int X { get { return this._x; } set { this._x = value; } }
        public int Y { get { return this._y; } set { this._y = value; } }
        public BaseUnit( int x, int y) 
        {
            _x = x;
            _y = y;
        }

        public virtual int Impact <T> ( T unit ) //метод атаки на другой Юнит
        {
            unit._heals = 23;
            return 0;
        }
    }
}
