using System;
using ClassLibrary;



namespace Lesson05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("тесты рациональных чисел");
            RationalNum Num1 = new RationalNum(1, 5);
            RationalNum Num2 = new RationalNum(5, 8);
            RationalNum Result;
            Console.WriteLine("Рациаональное число 1");
            Num1.Print();
            Console.WriteLine("Рациаональное число 2");
            Num2.Print();
            Console.WriteLine("Сумма двух рациональных чисел");
            Result = Num1 + Num2;
            Result.Print();
            Console.WriteLine("Разность двух рациональных чисел");
            Result = Num1 - Num2;
            Result.Print();
            Console.WriteLine("Инкремент рационального числа");
            Num1.Print();
            Num1++;
            Console.WriteLine("Результат");
            Num1.Print();
            Console.WriteLine("Декремент рационального числа");
            Num1.Print();
            Num1--;
            Console.WriteLine("Результат");
            Num1.Print();

            Console.WriteLine("Сравнения");
            Console.WriteLine("1/5 == 5/8 {0} ", Num1 == Num2);
            Console.WriteLine("1/5 != 5/8 {0} ", Num1 != Num2);
            Console.WriteLine("1/5 > 5/8 {0} ", Num1 > Num2);
            Console.WriteLine("1/5 < 5/8 {0} ", Num1 < Num2);
            Console.WriteLine("1/5 >= 5/8 {0} ", Num1 >= Num2);
            Console.WriteLine("1/5 <= 5/8 {0} ", Num1 <= Num2);

            string rNumToString = Num1.ToString();
            Console.WriteLine("Преобразование  ToString - " + rNumToString);

            rNumToString = (string)Num1;
            Console.WriteLine("Преобразование в String - " + rNumToString);

            float rNumToFloat = (float)Num1;
            Console.WriteLine("Преобразование в Float - " + rNumToFloat);

            int rNumToInt = (int)Num1;
            Console.WriteLine("Преобразование в Int - " + rNumToInt);

            RationalNum Num3 = new RationalNum(4, 5);
            RationalNum Num4 = new RationalNum(1, 4);
            Result = Num3 % Num4;
            Console.WriteLine("Остаток от деления ");
            Result.Print();

            Console.WriteLine("тесты комплексных чисел");
            ComplexNum cNum1 = new ComplexNum(1, -1);
            ComplexNum cNum2 = new ComplexNum(3, 6);
            ComplexNum ResCNum;
            Console.WriteLine("первое число");
            cNum1.Print();
            Console.WriteLine("второе число");
            cNum2.Print();
            Console.WriteLine("сложение");
            ResCNum = cNum1 + cNum2;
            ResCNum.Print();
            Console.WriteLine("вычитание");
            ResCNum = cNum1 - cNum2;
            ResCNum.Print();
            Console.WriteLine("умножение");
            ResCNum = cNum1 + cNum2;
            ResCNum.Print();
        }

    }
}
