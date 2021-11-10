using System;

namespace ClassLibrary
{
    public class RationalNum //класс - рациональной число
    {
        private int _numerator; //числитель
        private int _denominator; //знаменатель

        public int Numerator
        {
            get { return _numerator; }
        }
        public int Denominator
        {
            get { return _denominator; }
        }

        public RationalNum(int numerator, int denominator)
        {
            if (denominator <= 0) throw new ArgumentException("denominator"); //на 0 делить нельзя и отрицательным пусть может быть только числитель
            _numerator = numerator;
            _denominator = denominator;
        }

        public void Print()
        {
            Console.WriteLine("{0} / {1}", this.Numerator, this.Denominator);
        }

        public static RationalNum operator +(RationalNum rNum1, RationalNum rNum2) // оператор сложения
        {
            int b1 = rNum1.Denominator; // знаменатель 1го числа
            int b2 = rNum2.Denominator; // знаменатель 2го числа

            //приводим к общему знаменателю и складываем
            return new RationalNum((rNum1._numerator * b2) + (rNum2._numerator * b1), b2 * b1);
        }
        public static RationalNum operator -(RationalNum rNum1, RationalNum rNum2) // оператор вычетания
        {
            int b1 = rNum1.Denominator; // знаменатель 1го числа
            int b2 = rNum2.Denominator; // знаменатель 2го числа

            //приводим к общему знаменателю и вычитаем
            return new RationalNum((rNum1._numerator * b2) - (rNum2._numerator * b1), b2 * b1);
        }

        public static RationalNum operator *(RationalNum rNum1, RationalNum rNum2) // оператор умножения
        {
            return new RationalNum(rNum1._numerator * rNum2._numerator , rNum1._denominator * rNum2._denominator);
        }

        public static RationalNum operator /(RationalNum rNum1, RationalNum rNum2) // оператор деления
        {
            return new RationalNum(rNum1._numerator * rNum2._denominator, rNum1._denominator * rNum2._numerator);
        }

        public static int operator %(RationalNum rNum1, RationalNum rNum2) // оператор остаток от деления -------------------------------------------------------
        {
            RationalNum resultDel = new RationalNum(rNum1._numerator * rNum2._denominator, rNum1._denominator * rNum2._numerator); //делим
            resultDel = resultDel - rNum1; //из результат деления вычитаем
            int ostatok = (int)resultDel;
            return ostatok;
        }

        public static RationalNum operator ++(RationalNum rNum) //оператор инкремент ++
        {
            return new RationalNum(rNum._numerator + rNum._denominator, rNum._denominator);
        }

        public static RationalNum operator --(RationalNum rNum) //оператор декремент --
        {
            return new RationalNum(rNum._numerator - rNum._denominator, rNum._denominator);
        }

        public static bool operator ==(RationalNum rNum1, RationalNum rNum2) //оператор сравнения ==
        {
            //приводим к общему знаменателю и сравниваем
            //знаменатели сравнивать нет необходимости, они равны
            return ((rNum1._numerator * rNum2._denominator) == (rNum2._numerator * rNum1._denominator));
        }

        public static bool operator !=(RationalNum rNum1, RationalNum rNum2) //оператор сравнения !=
        {
            //приводим к общему знаменателю и сравниваем
            //знаменатели сравнивать нет необходимости, они равны
            return ((rNum1._numerator * rNum2._denominator) != (rNum2._numerator * rNum1._denominator));
        }

        public static bool operator >(RationalNum rNum1, RationalNum rNum2) //оператор сравнения >
        {
            return (rNum1._numerator * rNum2._denominator > rNum2._numerator * rNum1._denominator);
        }

        public static bool operator <(RationalNum rNum1, RationalNum rNum2) //оператор сравнения <
        {
            return (rNum1._numerator * rNum2._denominator < rNum2._numerator * rNum1._denominator);
        }

        public static bool operator >=(RationalNum rNum1, RationalNum rNum2) //оператор сравнения >=
        {
            return (rNum1._numerator * rNum2._denominator >= rNum2._numerator * rNum1._denominator);
        }

        public static bool operator <=(RationalNum rNum1, RationalNum rNum2) //оператор сравнения <=
        {
            return (rNum1._numerator * rNum2._denominator <= rNum2._numerator * rNum1._denominator);
        }

        public static implicit operator string(RationalNum rNum) //Преобразование в String
        {
            string rnum = rNum._numerator.ToString() + "/" + rNum._denominator.ToString();
            return (rnum);
        }

        public static implicit operator float(RationalNum rNum) //Преобразование в float
        {
            float _numerator = (float)rNum._numerator;
            float _denominator = (float)rNum._denominator;
            float rnum = _numerator / _denominator;
            return (rnum);
        }
        public static implicit operator int(RationalNum rNum) //Преобразование в int
        {
           return (rNum._numerator / rNum._denominator);
        }
    }
}
