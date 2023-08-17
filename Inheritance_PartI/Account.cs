using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_PartI
{
    internal class Account
    {
        private string acctNumber;
        private string acctHolderId;
        private double balance;

        //Constructor
        public Account(string acctNumber, string acctHolderId, double balance)
        {
            this.acctNumber = acctNumber;
            this.acctHolderId = acctHolderId;
            this.balance = balance;
        }

        //Properties
        public string AccountNumber
        {
            get { return acctNumber; }
        }

        public string AccountHolderId
        {
            get { return acctHolderId; }
            set { acctHolderId = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        //Methods
        public bool Withdraw(double amt)
        {
            bool enoughMoney = false;
            if(balance >= amt)
            {
                enoughMoney = true;
                balance -= amt;
            }
            return enoughMoney;
        }

        public void Deposit(double amt)
        {
            balance += amt;
        }

        public bool TransferTo(double amt,Account another)
        {
            bool enoughMoney;
            enoughMoney = Withdraw(amt);
            if (enoughMoney)
            {
                another.balance += amt;
            }
            return enoughMoney;
        }

        //ToString is an existing method in system, at here we override it.
        //当调用Console.WriteLine(对象)的时候，会对该对象自动调用ToString(对象)的操作
        //此处override ToString()方法后，能够自动调用改写后的ToString()函数
        public override string ToString()
        {
            string t;
            t = "Account Information:\nAccount Number = "+AccountNumber+" Account Holder ID = "+
                AccountHolderId+" Balance = "+ Balance+"\n";
            return t;
        }
    }
}
