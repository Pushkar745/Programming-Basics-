using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementup
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = 3;
            b = 4;
            if (a < b) Console.Write("a is less than b");
            if (a == b) Console.WriteLine("you won't see this");
            Console.WriteLine();
            c = a - b;
            Console.WriteLine("C contain -1");
            if (c >= 0) Console.WriteLine("c is non negative");
            if (c < 0) Console.WriteLine("c is negative");
            Console.WriteLine();
            c = b - a;
            Console.WriteLine("c Contain 1");
            if (c >= 0) Console.WriteLine("C is Non Negative");
            if (c < 0) Console.WriteLine("c is negative");


            Console.ReadLine();
        }
    }
}
