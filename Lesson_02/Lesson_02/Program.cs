using System;
using ClassLibrary;
// 2.Изменить класс счет в банке из упражнения таким образом, чтобы номер счета генерировался сам и был уникальным.
// Для этого надо создать в классе статическую переменную и метод, который увеличивает значение этого переменной.

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
            myAccaunt01.GetInfo();


            BankAccount myAccaunt02 = new BankAccount();
            myAccaunt02.GetAccountNum();
            myAccaunt02.AccountBalance = 2568;
            myAccaunt02.AccountType = typeAccount.debit;
            myAccaunt02.GetInfo();

            BankAccount myAccaunt03 = new BankAccount();
            myAccaunt03.GetAccountNum();
            myAccaunt03.AccountBalance = 7981;
            myAccaunt03.AccountType = typeAccount.kredit;
            myAccaunt03.GetInfo();

            BankAccount myAccaunt04 = new BankAccount();
            myAccaunt04.GetAccountNum();
            myAccaunt04.AccountBalance = 3289;
            myAccaunt04.AccountType = typeAccount.debit;
            myAccaunt04.GetInfo();
        }
    }
}
