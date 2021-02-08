using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] s = new int[10, 10];
            int t,i;
            int k = 2;
            for(t=0;t<3;t++)
            {
                for(i=0;i<9
                    ;i++)
                {
                    s[t, i] = (t * 3) + i + 1;
                    Console.Write(s[t, i] + "");
                }
                
            }
            Console.WriteLine(k++);
            Console.WriteLine(++k);
            Console.ReadLine();

        }
    }
}
