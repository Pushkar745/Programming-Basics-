using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, i, c, n, j;
            Console.WriteLine("Entetr the Range :");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                a = 0;
                b = 1;
                Console.Write(b + "\t");
                for(j=1;j<i;j++)
                {
                    c = a + b;
                    Console.Write(c + "\t");
                    a = b;
                    b = c;
                }
                Console.Write("\n");
                Console.ReadLine();
            }
        }
    }
}
