using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//(*) На перегрузку операторов. Описать класс комплексных чисел.
//Реализовать операцию сложения, умножения, вычитания, проверку на равенство двух комплексных чисел.
//Переопределить метод ToString() для комплексного числа. Протестировать на простом примере

namespace ClassLibrary
{
    public class ComplexNum
    {
        private float _Re; //действительная часть
        private float _Im; //мнимая часть

        public float Numerator
        {
            get { return _Re; }
        }
        public float Denominator
        {
            get { return _Im; }
        }

        public ComplexNum(float Re, float Im)
        {
            _Re = Re;
            _Im = Im;
        }

        public static ComplexNum operator +(ComplexNum cNum1, ComplexNum cNum2) // оператор сложения
        {
            return new ComplexNum(cNum1._Re + cNum2._Re, cNum1._Im + cNum2._Im);
        }
        public static ComplexNum operator -(ComplexNum cNum1, ComplexNum cNum2) // оператор вычетания
        {
            return new ComplexNum(cNum1._Re - cNum2._Re, cNum1._Im - cNum2._Im);
        }

        public static ComplexNum operator *(ComplexNum cNum1, ComplexNum cNum2) // оператор умножения
        {
            return new ComplexNum((cNum1._Re * cNum2._Re)-(cNum1._Im * cNum2._Im), (cNum1._Im * cNum2._Re) + (cNum2._Im * cNum1._Re));
        }

        public override string ToString()
        {
            string sign = "+";
            return (this._Re + sign + this._Im + "i");

        }

        public static bool operator ==(ComplexNum cNum1, ComplexNum cNum2) //оператор сравнения ==
        {
            return ((cNum1._Re == cNum2._Re) & (cNum1._Im == cNum2._Im));
        }

        public static bool operator !=(ComplexNum cNum1, ComplexNum cNum2) //оператор сравнения ==
        {
            return ((cNum1._Re != cNum2._Re) || (cNum1._Im != cNum2._Im));
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }

    }
}
