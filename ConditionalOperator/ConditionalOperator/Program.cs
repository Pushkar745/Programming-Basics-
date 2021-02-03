using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            for(int i=-5;i<6;i++)
            {
                result = i != 0 ? 100 / i : 0;
                if (i != 0)
                    Console.WriteLine("100 /" + i + "is" + result);
                Console.ReadLine();

            }
        }
    }
}
