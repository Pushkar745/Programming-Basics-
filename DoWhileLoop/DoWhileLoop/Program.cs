using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display the digits of an integer in reverse order
            int num;
            int nectdigit;
            num = 198;
            Console.WriteLine("Number :" + num);
            Console.WriteLine("Number in reverse order :");
            do
            {
                nectdigit = num % 10;
                Console.Write(nectdigit);
                num = num / 10;
            }
            while (num > 0);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
