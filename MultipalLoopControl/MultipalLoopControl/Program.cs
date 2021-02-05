using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipalLoopControl
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int small, large;
            int num;
            num = 100;
            small = large = 1;
            for(i=2,j=num/2;(i<=num/2)&(j>=2);i++,j--)
            {
                if ((small == 1) & ((num % i) == 0))
                    small = i;
                if ((large == 1) & ((num % j) == 0))
                    large = j;
            }
            Console.WriteLine("largest Factor:" + large);
            Console.WriteLine("smallest factor:" + small);
            Console.ReadKey();
        }
    }
}
