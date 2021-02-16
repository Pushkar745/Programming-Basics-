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
            var s3 = 5;
            var s4 = 6;
            //Dynamically init hypot
            double hypot = Math.Sqrt((s1 * s1) + (s2 * s2));
            var hypot1 = Math.Sqrt((s3 * s3) + (s4 * s4));//These are now implicitly typed veriables.
            //They are int type because their initializingexpressions are of type int
            Console.WriteLine("Hypotenus of triange with sides"+s1+"by"+s2+ "is");
            Console.WriteLine("{0:#.###}.", hypot);
            Console.WriteLine("Hypotenus of triange with sides" + s3 + "by" + s4 + "is");
            Console.WriteLine("{0:#.###}.", hypot1);
            Console.WriteLine(typeof(int));
            Console.ReadLine();

                 
        }
    }
}
