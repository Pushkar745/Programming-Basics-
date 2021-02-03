using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLargeAndSmallFact
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int smallest, largest;
            int num;
            num = 100;
            smallest = largest = 1;
            for(i=2,j=num/2;(i<=num/2)&(j>=2);i++,j--)
            {
                if ((smallest == 1) & ((num % i) == 0))
                    smallest = i;
                if ((largest == 1) & ((num % j) == 0))
                    largest = j;
            }
            Console.WriteLine("Largest factor:" + largest);
            Console.WriteLine("Smallest factor:" + smallest);
            Console.ReadLine();
            /*loop condition can be any bool expression.
             The for loop is controlled by the value of done
             It does not need to invole the loop control veriable
             */
            int a, b;
            bool done = false;
            for (a = 0, b = 100; !done;a++,b--)
            {
                if (a * a >= b) done = true;
                Console.WriteLine("a,b:" + a + "" + b);
                Console.ReadLine();
            }
                
        }
    }
}
