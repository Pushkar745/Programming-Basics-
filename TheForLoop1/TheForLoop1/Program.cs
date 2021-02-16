using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheForLoop1
{
    class Program
    {
        //Determine if a number is Prime .If it is not Then
        //display its largest factor
        static void Main(string[] args)
        {
            int num;
            int i;
            int fact;
            bool isprime;
            for(num =2;num<20;num++)
            {
                isprime = true;
                fact = 0;//see if num is evenly divisible
                for(i=2;i<=num/2;i++)
                {
                    if((num % i)==0)
                    {
                        //num is evenly divisible .Thus it is not prime
                        isprime = false;
                        fact = i;
                    }
                }
                if (isprime)
                    Console.WriteLine(num + "is prime");
                else
                    Console.WriteLine("Largest factore of " + num + "is" + fact);
                Console.ReadLine();
            }
            int a, b;
            for(a=0,b=10;a<b;a++,b--)
            {
                Console.WriteLine("a and b : " + a + "" + b);
                Console.ReadLine();
            }
        }
    }
}
