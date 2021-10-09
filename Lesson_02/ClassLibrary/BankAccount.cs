using System;


namespace ClassLibrary
{
    public enum typeAccount { debit, kredit }
    public class BankAccount
    {
        private int accountNum;
        private int accountBalance;
        private typeAccount accountType;

        public int AccountNum //свойство - номер счета
        {
            get
            {
                return this.accountNum;
            }
            set
            {
                this.accountNum = value;
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


    }
}
