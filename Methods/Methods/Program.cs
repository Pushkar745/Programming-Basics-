using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        /* A method is a block of code which only runs when it is called.

You can pass data, known as parameters, into a method.

Methods are used to perform certain actions, and they are also known as functions. */
        static void My()
        {
            Console.Write("Hi");
        }
        static void Main(string[] args)
        {
            My();
            Console.ReadKey(); 

        }
    }
}
