using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0, m;
            Console.WriteLine("Enter the Number");
            n = Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.WriteLine("Sum is =" + sum);
            Console.ReadKey();
        }
    }
}
