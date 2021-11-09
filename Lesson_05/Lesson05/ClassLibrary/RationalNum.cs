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
            //int a1 = rNum1._numerator;  // числитель 1го числа
            int b1 = rNum1.Denominator; // знаменатель 1го числа
            //int a2 = rNum2._numerator;  // числитель 2го числа
            int b2 = rNum2.Denominator; // знаменатель 2го числа

            //приводим к общему знаменателю и складываем

            return new RationalNum((rNum1._numerator * b2) + (rNum2._numerator * b1), b2 * b1);
        }

    }

    public static void PrintRationalNum(RationalNum _num1, RationalNum _num2)
    {
        Console.WriteLine("{0} / {1}", this.Numerator, this.Denominator);
    }

}
