using System;


namespace ClassLibrary
{
    public enum typeAccount { debit, kredit }
    public class BankAccount
    {
        static int count = 0;
        private int accountNum;
        private int accountBalance;
        private typeAccount accountType;

        public BankAccount(int _accountBalance) //конструктор заполнения поля баланса счета
        {
            NewAccountNum();
            this.accountBalance = _accountBalance;
            this.accountType = typeAccount.debit;
        }
        public BankAccount(typeAccount _typeAccount) //конструктор заролнения поля тип счета
        {
            NewAccountNum();
            this.accountBalance = 0;
            this.accountType = _typeAccount;
        }
        public BankAccount(int _accountBalance, typeAccount _typeAccount) //конструктор заполнения баланса и типа счета
        {
            NewAccountNum();
            this.accountBalance = _accountBalance;
            this.accountType = _typeAccount;
        }
        public int AccountNum //свойство - номер счета, номер счета нельзя поменять, он присвается автоматически
        {
            get
            {
                return this.accountNum;
            }
        }
        public int AccountBalance //свойство - баланс счета, можно только смотреть, считаю что правильно будет менять только через методы самого класса
        {
            get
            {
                return this.accountBalance;
            }
        }
        public typeAccount AccountType //свойство - тип счета, считаю что тип счета не может меняться, он присваивается один раз
        {
            get
            {
                return this.accountType;
            }
        }

        public bool GetCash(int _cash) //метод - снять деньги со счета
        {
            try
            {
                if (this.accountBalance - _cash < 0) return false;
                else
                {
                    this.accountBalance = this.accountBalance - _cash;
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public bool PutCash(int _cash) // метод - добавить деньги на счет
        {
            try
            {
                this.accountBalance = this.accountBalance + _cash;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void NewAccountNum() // создание нового счета
        {
            accountNum = count++;
        }
        public void GetInfo()
        {
            Console.WriteLine("Иформация по счету № {0} \n" +
                              "Баланс счета - {1}\n" +
                              "Тип счета    - {2}",
                              this.accountNum,
                              this.accountBalance,
                              this.accountType);
            Console.WriteLine("---------------------------");
        }
    }
}
