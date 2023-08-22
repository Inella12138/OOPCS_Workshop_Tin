using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_PartII
{
    class TestPropagation
    {
        public static void Main()
        {
            Console.WriteLine("Enter Main.");
            ExcPropagation mc = new ExcPropagation();
            try
            {
                mc.M1();
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter catch block of Main.");
                Console.WriteLine("Exception from: {0}",
                           e.TargetSite);
                Console.WriteLine("Exit catch block of Main.");
            }
            Console.WriteLine("Exit Main.");
        }
    }

}
