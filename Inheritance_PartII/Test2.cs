using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_PartII
{
    internal class Test2
    {
        static void Main(string[] args)
        {
            bool enfMoney;

            Account account1 = new OverdraftAccount("Account1", "LRJ", 2000);
            Console.WriteLine(account1);
            SavingAccount account2 = new SavingAccount("Saving1", "LRY", 2000);
            Console.WriteLine(account2);
            CurrentAccount account3 = new CurrentAccount("Current1", "LRB", 2000);
            Console.WriteLine(account3);

            account1.CreditInterest();
            Console.WriteLine(account1);
            account2.CreditInterest();
            Console.WriteLine(account2);
            account3.CreditInterest();
            Console.WriteLine(account3);

            account1.Deposit(200);
            Console.WriteLine(account1);
            account2.Deposit(200);
            Console.WriteLine(account2);
            account3.Deposit(200);
            Console.WriteLine(account3);

            enfMoney = account1.Withdraw(200);
            if (enfMoney)
            {
                Console.WriteLine("Withdraw 200 successfully!");
            }
            else { Console.WriteLine("Failed to withdraw 200!"); }
            Console.WriteLine(account1);
            enfMoney = account1.Withdraw(4000);
            if (enfMoney)
            {
                Console.WriteLine("Withdraw 4000 successfully!");
            }
            else { Console.WriteLine("Failed to withdraw 4000!"); }
            Console.WriteLine(account1);


            enfMoney = account2.Withdraw(500);
            if (enfMoney)
            {
                Console.WriteLine("Withdraw 500 successfully!");
            }
            else { Console.WriteLine("Failed to withdraw 500!"); }
            Console.WriteLine(account2);

            enfMoney = account3.Withdraw(2000);
            if (enfMoney)
            {
                Console.WriteLine("Withdraw 2000 successfully!");
            }
            else { Console.WriteLine("Failed to withdraw 2000!"); }
            Console.WriteLine(account3);

            account1.CreditInterest();
            Console.WriteLine(account1);
            account2.CreditInterest();
            Console.WriteLine(account2);
            account3.CreditInterest();
            Console.WriteLine(account3);
        }
    }
}
