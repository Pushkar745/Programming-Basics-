using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbertriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, l, n;
            Console.Write("Enter The Range=");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n - 1; j++)
                {
                    Console.Write("");

                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }
                for (l = i - 1; l >= 1; l--)
                {
                    Console.Write(l);
                }
                Console.Write("\n");
                Console.ReadLine();
            }

        }
    }
}
    
