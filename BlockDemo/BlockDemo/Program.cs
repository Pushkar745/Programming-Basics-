using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Another key element of the c# is code block
            //Opening and cloosing curly braces 
            int i ,j ,d,k ,prod,sum;
            i = 5;//int i=5

            j = 6;
            if (i!=0)
            {
                Console.WriteLine("I does not equal to zero");
                d = j / i;
                Console.WriteLine("j/i is : " + d);
                Console.ReadLine();
            }

            Console.WriteLine();
            sum = 0;
            prod = 1;
            for(k=1;k<=10;k++)
            {
                sum = sum + k;
                prod = prod * k;
                Console.WriteLine("The sum  is :"+ sum);
                Console.WriteLine("The prod is :" + prod);
                Console.ReadLine();

            }

        }
    }
}
