using System;
using ClassLibrary;
//Создать класс рациональных чисел. В классе два поля – числитель и знаменатель.
//Предусмотреть конструктор. Определить операторы ==, != (метод Equals()), <, >, <=, >=, +, – , ++, --.
//Переопределить метод ToString() для вывода дроби. Определить операторы преобразования типов между типом дробь, float, int. Определить операторы *, /, %. 

//(*) На перегрузку операторов. Описать класс комплексных чисел.
//Реализовать операцию сложения, умножения, вычитания, проверку на равенство двух комплексных чисел.
//Переопределить метод ToString() для комплексного числа. Протестировать на простом примере




namespace Lesson05
{
    class Program
    {
        static void Main(string[] args)
        {
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

            string rNumToString = (string)Num1;
            Console.WriteLine("Преобразование в String - " + rNumToString);

            float rNumToFloat = (float)Num1;
            Console.WriteLine("Преобразование в Float - " + rNumToFloat);

            int rNumToInt = (int)Num1;
            Console.WriteLine("Преобразование в Int - " + rNumToInt);

        }

    }
}
