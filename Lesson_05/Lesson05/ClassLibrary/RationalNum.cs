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

        public static RationalNum operator +(RationalNum rN1, RationalNum rN2)
        {
            return new RationalNum(rN1._numerator + rN2._numerator, rN1.Denominator + rN2.Denominator);
        }

    }

}
