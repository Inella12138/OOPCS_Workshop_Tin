using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_PartII
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

        //overdraft account可以无条件取款，其他账户需要balance > 0
        //定义一个virtual的withdraw()方法可以让程序共用一个方法名
        public virtual bool Withdraw(double amt)
        {
            balance -= amt;
            return true;
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

        public override string ToString()
        {
            string t;
            t = "Account:\nAccount Number = "+AccountNumber+" Account Holder ID = "+
                AccountHolderId+" Balance = "+ Balance+"\n";
            return t;
        }

        //在母类中定义一个CalculateInterest()方法，此处并无作用，只是为了让子类能够override
        //若不在此定义一个virtual方法，每个子类(saving,current，overdraft)
        //中的CalculateInterest()方法重名，可能引起潜在问题
        public virtual double CalculateInterest()
        {
            return 0;
        }

        //加利息函数，各子类中都相同，直接定义在母类中
        public void CreditInterest()
        {
            Deposit(CalculateInterest());
        }
    }
}
