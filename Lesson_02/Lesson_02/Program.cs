using System;
using ClassLibrary;
//1.Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип банковского счета (использовать перечислимый тип).
//  Предусмотреть методы для доступа к данным – заполнения и чтения.
//  Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.

namespace Lesson_02
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccaunt = new BankAccount();
            myAccaunt.AccountNum = 1;
            myAccaunt.AccountBalance = 1000;
            myAccaunt.AccountType = typeAccount.debit;
            Console.WriteLine("Мой новый счет! \n" +
                              "номер счета  - {0}\n" +
                              "Баланс счета - {1}\n" +
                              "Тип счета    - {2}",
                              myAccaunt.AccountNum,
                              myAccaunt.AccountBalance,
                              myAccaunt.AccountType);
        }
    }
}
