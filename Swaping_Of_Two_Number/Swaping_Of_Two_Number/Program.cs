using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swaping_Of_Two_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter The number a");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number b");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swap a="+a+ "b="+b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("After Swap a=" + a + "b=" + b );
            Console.ReadKey();

        }
    }
}
