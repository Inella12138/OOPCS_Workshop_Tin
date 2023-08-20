using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_PartII
{
    public class OverdraftAccount : Account
    {
        private static double intrRate = 0.0025;
        private static double loanRate = 0.06;

        //Constructor
        public OverdraftAccount(string acctNumber, string acctHolderId, double balance) :
            base(acctNumber, acctHolderId, balance)
        { }

        //Methods
        public override double CalculateInterest()
        {
            if (Balance >= 0)
            {
                return Balance * intrRate;
            }
            else { return Balance * loanRate; }
        }

        public override string ToString()
        {
            string t = "Overdraft";
            t = t + base.ToString();
            return t;
        }

        public override string NotShowId()
        {
            string t = "Overdraft";
            t = t + base.NotShowId();
            return t;
        }

    }
}
