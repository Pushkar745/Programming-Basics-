using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOTOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte b = -34;
            for(int t=128;t>0;t=t/2)
            {
                if ((b & t) != 0) Console.Write("1 ");
                if ((b & t) == 0) Console.Write("0 ");
            }
            Console.WriteLine();
            //reverse all bits
            b = (sbyte)~b;
            for(int t=128;t>0;t=t/2)
            {
                if ((b & t) != 0) Console.Write("1 ");
                if ((b & t) == 0) Console.Write("0 ");
            }
            Console.ReadLine();
        }
    }
}
