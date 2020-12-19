using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1, number;
            Console.WriteLine("Enter the any number");
            number = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<number;i++)
            {
                fact = fact * i;

            }
            Console.Write("factorial" + number + "is" + fact);
            Console.ReadKey();

        }
    }
}
