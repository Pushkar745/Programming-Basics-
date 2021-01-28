using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicInit
{
    class Program
    {//demostrate dynamic initialization
        static void Main(string[] args)
        {
            //Length of sides
            double s1 = 4.0;
            double s2 = 5.0;
            //Dynamically init hypot
            double hypot = Math.Sqrt((s1 * s1) + (s2 * s2));
            Console.WriteLine("Hypotenus of triange with sides"+s1+"by"+s2+ "is");
            Console.WriteLine("{0:#.###}.", hypot);
            Console.ReadLine();

                 
        }
    }
}
