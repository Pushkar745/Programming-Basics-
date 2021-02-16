using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Floating_PointTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find The Radius of a circle given its area.
            Double r;
            Double area;
            Double theta; 
            area = 10.0;
            r = Math.Sqrt(area / 3.1416);
            Console.WriteLine("Radius is " + r);
            Console.ReadKey();
            Console.WriteLine();
            //Demostration Math.sin(),Math.cos(), and Math.Tan.
            for (theta = 0.1; theta <= 1.0; theta = theta + 0.1)
                Console.WriteLine("Sin of theta =" + theta + "is" + Math.Sin(theta));
            Console.WriteLine("Cos of theta =" + theta + "is" + Math.Cos(theta));
            Console.WriteLine("Tan of Theta = " + theta + "is" + Math.Tan(theta));
            Console.ReadKey();
            Console.WriteLine();
            //USe of decimal type to compute a discount,
            decimal price;
            decimal discount;
            decimal dp;
            price = 19.95m;
            discount = 0.15m;
            dp = price - (price * discount);
            Console.WriteLine("The Discounted price is $" + dp);
            Console.ReadKey();



        }
    }
}
