using System;


namespace ClassLibrary
{
    public enum typeAccount 
    { 
        debit = 0, 
        kredit = 1
    }
    public class BankAccount
    {
        static int count = 1;
        private int accountNum;
        private int accountBalance;
        private typeAccount accountType;
        private DateTime timeCreate;

        public BankAccount(int _accountBalance) //конструктор заполнения поля баланса счета
        {
            NewAccountNum();
            this.accountBalance = _accountBalance;
            this.accountType = typeAccount.debit;
            this.timeCreate = DateTime.Now;
        }
        public BankAccount(typeAccount _typeAccount) //конструктор заролнения поля тип счета
        {
            NewAccountNum();
            this.accountBalance = 0;
            this.accountType = _typeAccount;
            this.timeCreate = DateTime.Now;
        }
        public BankAccount(int _accountBalance, typeAccount _typeAccount) //конструктор заполнения баланса и типа счета
        {
            NewAccountNum();
            this.accountBalance = _accountBalance;
            this.accountType = _typeAccount;
            this.timeCreate = DateTime.Now;
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

        public static bool operator ==(BankAccount BaAcc1, BankAccount BaAcc2) //оператор сравнения ==
        {
            //у проверяемых счетов должны быть одинаковые типы счетов, сумма на счете и номер счета, но я бы сравнивал только номер счета, думаю что этого было бы достаточно
            return (BaAcc1.AccountType == BaAcc2.AccountType & BaAcc1.AccountBalance == BaAcc2.AccountBalance & BaAcc1.AccountNum == BaAcc2.AccountNum);
        }

        public static bool operator !=(BankAccount BaAcc1, BankAccount BaAcc2) //оператор сравнения !=
        {
            return (BaAcc1.AccountType != BaAcc2.AccountType || BaAcc1.AccountBalance != BaAcc2.AccountBalance || BaAcc1.AccountNum != BaAcc2.AccountNum);
        }

        public bool Equals(BankAccount obj) //Equals переопределение
        {
            return this == obj;
        }
        public override string ToString() //ToString переопределение
        {
            return "Счет N " + this.AccountNum + " " + this.accountType;
        }

        public override int GetHashCode() //GetHashCode переопределение
        {
            int hashCode = this.AccountNum * (int)this.timeCreate.ToFileTime();
            return hashCode;
        }


        public bool TransferCash(BankAccount _fromAccount, int _cash) //Метод первода суммы денег (_cash) со счета (_fromAccount) на текущий счет
        {
            if (_fromAccount.accountBalance < _cash) return false;
            else
            {
                _fromAccount.accountBalance = _fromAccount.accountBalance - _cash;
                this.accountBalance = this.accountBalance + _cash;
                return true;
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
