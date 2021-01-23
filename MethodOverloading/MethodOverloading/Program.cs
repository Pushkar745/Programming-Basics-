using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static int Sum(int a,int b)
        {
            return a + b;

        }
        static double Sum(double a, double b)
        {
            return a * b;

        }

        static void Main(string[] args)
        {
            int Myno = Sum(5, 10);
            double myNo = Sum(5.8,2.5);
            Console.WriteLine(Myno);
            Console.WriteLine(myNo);
            Console.ReadLine();

        }
    }
}
