using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            for (count = 1; count < 100; count++)
                Console.WriteLine("this is a count :" + count);
            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}
