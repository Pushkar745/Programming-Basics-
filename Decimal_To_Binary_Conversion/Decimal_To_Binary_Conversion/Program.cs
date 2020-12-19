using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_To_Binary_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            int[] a = new int[10];
            Console.Write("Enter the Number to Convert:");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=0;n>0;i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Binary Of the Given Number = ");
            for(i=0;i>=0;i--)
            {
                Console.Write(a[i]);
                Console.ReadKey();
            }

        }
    }
}
