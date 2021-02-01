using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseAND
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort num;
            num = 10;
            if ((num & 1) == 1)
                {
                Console.WriteLine("This won't display.");

            }
            num = 11;
            if ((num & 1) == 1)
                Console.WriteLine(num + "is Odd");
            Console.ReadKey();

        }
    }
}
