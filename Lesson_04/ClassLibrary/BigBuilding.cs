using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BigBuilding : Building
    {
        static int _num = 0;        // счетчик номеров домов
        

        public int NumBuilding { get { return this._numBuilding; } }
        public int Height { get { return this._height; } set { this._height = value; } }
        public int NumFloors { get { return this._numFloors; } set { this._numFloors = value; } }
        public int NumAppartment { get { return this._numAppartment; } set { this._numAppartment = value; } }
        public int NumEntrances { get { return this._numEntrances; } set { this._numEntrances = value; } }


        public BigBuilding(int Height, int NumFloors, int NumAppartment, int NumEntrances)
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

        public int GetNumAppartmPerEntr()   // метод - возвращает количество квартир в 1 подъезде
        {
            return this._numAppartment / this._numEntrances;
        }

        public int GetNumAppartmPerFloor()   // метод - возвращает количество квартир на одном этаже
        {
            return this._numAppartment / this._numFloors;
        }

    }
}
