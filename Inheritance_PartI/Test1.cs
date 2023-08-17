using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_PartI
{
    internal class Test1
    {
        static void Main(string[] args)
        {
            bool enfMoney;

            Account account1 = new Account("S0000111", "S1111111A", 2000);
            Console.WriteLine(account1);

            account1.Deposit(200);
            Console.WriteLine(account1);

            enfMoney = account1.Withdraw(200);
            if (enfMoney)
            {
                Console.WriteLine("Withdraw successfully!");
            }
            else { Console.WriteLine("Failed to withdraw!"); }
            Console.WriteLine(account1);

            enfMoney = account1.Withdraw(4000);
            if (enfMoney)
            {
                Console.WriteLine("Withdraw successfully!");
            }
            else { Console.WriteLine("Failed to withdraw!"); }
            Console.WriteLine(account1);
        }
    }
}
