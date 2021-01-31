using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalAnd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n ,d;
            n = 10;
            d = 2;
            if (d != 0 && (n % d) == 0)
                Console.WriteLine(d + "is factor of " + n);
            d = 0;
            if (d != 0 && (n * d) == 0)
                Console.WriteLine(d + "is factore of " + n);
            try
            {
                if (d != 0 & (n % d) == 0)
                    Console.WriteLine(d + "is factore of " + n);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
