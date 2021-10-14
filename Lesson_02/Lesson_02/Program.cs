using System;
using ClassLibrary;
//4. В классе все методы для заполнения и получения значений полей заменить на свойства. Написать тестовый пример.
//5. * Добавить в класс счет в банке два метода: снять со счета и положить на счет.
//  Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае положительного результата изменяет баланс.


namespace Lesson_02
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccaunt01 = new BankAccount(1000);
            myAccaunt01.GetInfo();
            Console.WriteLine("кладем на счет 234");
            myAccaunt01.PutCash(234);
            myAccaunt01.GetInfo();

            BankAccount myAccaunt02 = new BankAccount(typeAccount.debit);
            myAccaunt02.GetInfo();
            Console.WriteLine("кладем на счет 4354");
            myAccaunt02.PutCash(4354);
            myAccaunt02.GetInfo();

            BankAccount myAccaunt03 = new BankAccount(250, typeAccount.kredit);
            myAccaunt03.GetInfo();

            Console.WriteLine("перевод 2354 с myAccaunt02 на myAccaunt03");
            if (myAccaunt03.TransferCash(myAccaunt02, 2354)) Console.WriteLine("Получилось первести указанную сумму");
            else Console.WriteLine("Не получилось снять указанную сумму");
            myAccaunt02.GetInfo();
            myAccaunt03.GetInfo();

        }
    }
}
