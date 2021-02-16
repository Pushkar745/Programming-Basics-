using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileStatement
{
    class Program
    {
        //Compute the orderof magnitude of an integer
        static void Main(string[] args)
        {
            int num;
            int mag;
            num = 435679;
            mag = 0;
            Console.WriteLine("Number " + num);
            while(num>0)
            {
                mag++;
                num = num / 10;
            };
            Console.WriteLine("Magnitude :" + mag);
            Console.ReadLine();
        }
    }
}
