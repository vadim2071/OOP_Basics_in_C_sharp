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
        private int _armor; //Броня
        private int _attack; //Сила атаки
        private int _health; //здоровье
        private int _maxStep; //максимальный шаг пеедвижения
        private int _x; //положение юнита
        private int _y;

        public int Armor { get { return this._armor; } set { this._armor = value; } }
        public int Attack { get { return this._attack; } set { this._attack = value; } }
        public int Health { get { return this._health; } set { this._health = value; } }
        public int MaxStep { get { return this._maxStep; } set { this._maxStep = value; } }
        public int X { get { return this._x; } set { this._x = value; } }
        public int Y { get { return this._y; } set { this._y = value; } }
        public BaseUnit(int armor, int attack, int health, int maxStep, int x, int y) 
        {
            _armor = armor;
            _attack = attack;
            _health = health;
            _maxStep = maxStep;
            _x = x;
            _y = y;
        }

        public virtual int Attack()
        {
            return 0;
        }
    }
}
