using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelLogOps
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            bool b1, b2;
            i = 10;
            j = 11;
            if (i < j) Console.WriteLine("i<j");
            if (i <= j) Console.WriteLine("i<=j");
            if (i != j) Console.WriteLine("i!=j");
            if (i == j) Console.WriteLine("This won't be executed");
            if (i >= j) Console.WriteLine("This won't be executed");
            if (i > j) Console.WriteLine("This won't be executed");
            b1 = true;
            b2 = false;
            if (b1 & b2) Console.WriteLine("This won't be executed");
            if (b1 | b2) Console.WriteLine("true");
            if (!(b1 & b2)) Console.WriteLine("opposite o b1&b2");
            if (b1 ^ b2) Console.WriteLine("b1 ^ b2 is true");
            Console.ReadLine();
        }
    }
}
