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
            set
            {
                this.accountBalance = value;
            }
        }
        public typeAccount AccountType //свойство - тип счета
        {
            get
            {
                return this.accountType;
            }
            set
            {
                this.accountType = value;
            }
        }
        public int GetAccountNum()
        {
            accountNum = count++;
            return accountNum;
        }
        public void GetInfo()
        {
            Console.WriteLine("Иформация по счету № {0} \n" +
                              "Баланс счета - {1}\n" +
                              "Тип счета    - {2}",
                              this.AccountNum,
                              this.AccountBalance,
                              this.AccountType);
            Console.WriteLine("---------------------------");
        }

    }
}
