using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=-10;i<=10;i++)
            {
                if (i > 0) break;//terminate loop when i is positive
                Console.Write(i + "");
            }
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
