using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_PartII
{
    public class CurrentAccount : Account
    {
        private static double intrRate = 0.0025;

        //Constructor
        public CurrentAccount(string acctNumber, string acctHolderId, double balance) :
            base(acctNumber, acctHolderId, balance)
        { }

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
            string t = "Current";
            t = t + base.ToString();
            return t;
        }

        public override string NotShowId()
        {
            string t = "Current";
            t = t + base.NotShowId();
            return t;
        }
    }
}
