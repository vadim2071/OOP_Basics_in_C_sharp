using System;
using ClassLibrary;
//3. В классе банковский счет удалить методы заполнения полей. Вместо этих методов создать конструкторы.
//  Переопределить конструктор по умолчанию, создать конструктор для заполнения поля баланс, конструктор для заполнения поля тип банковского счета,
//  конструктор для заполнения баланса и типа банковского счета. Каждый конструктор должен вызывать метод, генерирующий номер счета.


namespace Lesson_02
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAccaunt01 = new BankAccount(1000);
            myAccaunt01.GetInfo();

            BankAccount myAccaunt02 = new BankAccount(typeAccount.debit);
            myAccaunt02.GetInfo();

            BankAccount myAccaunt03 = new BankAccount(2563, typeAccount.kredit);
            myAccaunt03.GetInfo();
        }
    }
}
