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
            GetAccountNum();
            this.accountBalance = _accountBalance;
            this.accountType = typeAccount.debit;
        }
        public BankAccount(typeAccount _typeAccount) //конструктор заролнения поля тип счета
        {
            GetAccountNum();
            this.accountBalance = 0;
            this.accountType = _typeAccount;
        }
        public BankAccount(int _accountBalance, typeAccount _typeAccount) //конструктор заполнения баланса и типа счета
        {
            GetAccountNum();
            this.accountBalance = _accountBalance;
            this.accountType = _typeAccount;
        }

        public void GetAccountNum()
        {
            accountNum = count++;
            //return accountNum;
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

        // оставляю свойства толька для возможности получения информации
        public int AccountNum //свойство - номер счета
        {
            get
            {
                return this.accountNum;
            }
        }
        public int AccountBalance //свойство - баланс счета
        {
            get
            {
                return this.accountBalance;
            }
        }
        public typeAccount AccountType //свойство - тип счета
        {
            get
            {
                return this.accountType;
            }
        }


    }

}
