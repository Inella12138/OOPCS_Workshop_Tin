using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_PartII
{
    public class SavingAccount : Account
    {
        private static double intrRate = 0.01;

        //Constructor
        public SavingAccount(string acctNumber, string acctHolderId, double balance):
            base(acctNumber,acctHolderId,balance){}

        //Methods
        public override bool Withdraw(double amt)
        {
            if (Balance >= amt)
            {
                return base.Withdraw(amt);
            }
            else return false;
        }

        public override double CalculateInterest() 
        { 
            return Balance * intrRate; 
        }

        public override string ToString()
        {
            string t = "Saving";
            t = t + base.ToString();
            return t;
        }


        public override string NotShowId()
        {
            string t = "Saving";
            t = t + base.NotShowId();
            return t;
        }

    }
}
