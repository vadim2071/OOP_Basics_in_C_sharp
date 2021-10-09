using System;
using ClassLibrary;
//2. Изменить класс счет в банке из упражнения таким образом, чтобы номер счета генерировался сам и был уникальным.
//  Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.

namespace Lesson_02
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccaunt01 = new BankAccount();
            myAccaunt01.GetAccountNum();
            myAccaunt01.AccountBalance = 1000;
            myAccaunt01.AccountType = typeAccount.debit;
            Console.WriteLine("Мой новый счет! \n" +
                              "номер счета  - {0}\n" +
                              "Баланс счета - {1}\n" +
                              "Тип счета    - {2}",
                              myAccaunt01.AccountNum,
                              myAccaunt01.AccountBalance,
                              myAccaunt01.AccountType);

            Console.WriteLine("---------------------------");

            BankAccount myAccaunt02 = new BankAccount();
            myAccaunt02.GetAccountNum();
            myAccaunt02.AccountBalance = 2568;
            myAccaunt02.AccountType = typeAccount.debit;
            Console.WriteLine("Мой новый счет! \n" +
                              "номер счета  - {0}\n" +
                              "Баланс счета - {1}\n" +
                              "Тип счета    - {2}",
                              myAccaunt02.AccountNum,
                              myAccaunt02.AccountBalance,
                              myAccaunt02.AccountType);

            Console.WriteLine("---------------------------");

            BankAccount myAccaunt03 = new BankAccount();
            myAccaunt03.GetAccountNum();
            myAccaunt03.AccountBalance = 7981;
            myAccaunt03.AccountType = typeAccount.kredit;
            Console.WriteLine("Мой новый счет! \n" +
                              "номер счета  - {0}\n" +
                              "Баланс счета - {1}\n" +
                              "Тип счета    - {2}",
                              myAccaunt03.AccountNum,
                              myAccaunt03.AccountBalance,
                              myAccaunt03.AccountType);

            Console.WriteLine("---------------------------");

            BankAccount myAccaunt04 = new BankAccount();
            myAccaunt04.GetAccountNum();
            myAccaunt04.AccountBalance = 3289;
            myAccaunt04.AccountType = typeAccount.debit;
            Console.WriteLine("Мой новый счет! \n" +
                              "номер счета  - {0}\n" +
                              "Баланс счета - {1}\n" +
                              "Тип счета    - {2}",
                              myAccaunt04.AccountNum,
                              myAccaunt04.AccountBalance,
                              myAccaunt04.AccountType);
        }
    }
}
