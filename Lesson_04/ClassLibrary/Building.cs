//1. Реализовать класс для описания здания (уникальный номер здания, высота, этажность, количество квартир, подъездов).
//Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати.
//Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д.
//Предусмотреть возможность, чтобы уникальный номер здания генерировался программно.
//Для этого в классе предусмотреть статическое поле, которое бы хранило последний использованный номер здания,
//и предусмотреть метод, который увеличивал бы значение этого поля.
using System;

namespace ClassLibrary
{
    public class Building
    {
        static int _num = 0;        // счетчик номеров домов
        private int _numBuilding;    // номер здания
        private int _height;         // высота
        private int _numFloors;    // этажность
        private int _numAppartment; // количество квартир
        private int _numEntrances; // количество подъездов

        public int NumBuilding {get {return this._numBuilding;}set{this._numBuilding = value;}}
        public int Height{get { return this._height; }set { this._height = value; }}
        public int NumFloors { get { return this._numFloors; } set { this._numFloors = value; } }
        public int NumAppartment { get { return this._numAppartment; } set { this._numAppartment = value; } }
        public int NumEntrances { get { return this._numEntrances; } set { this._numEntrances = value; } }

        public Building(int Height, int NumFloors, int NumAppartment, int NumEntrances)
        {
            this._numBuilding = NewNum();
            this._height = Height;
            this._numFloors = NumFloors;
            this._numAppartment = NumAppartment;
            this._numEntrances = NumEntrances;
        }

        static int NewNum()
        {
            _num++;
            return _num;
        }

        public int GetHeightFloor()     // метод - возвращает высоту этажа
        {
            return this._height / this._numFloors;
        }

    }
}
