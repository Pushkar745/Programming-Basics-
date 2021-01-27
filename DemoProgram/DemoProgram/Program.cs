using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            double t0, t, v;
            double c  ;
            
            double vpow;
            Console.WriteLine("time in observers own frame of reference (rest time)");
            t = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("time in observers own frame of reference (rest time)");
            //t0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the speed of the moving object");
            v = Double.Parse(Console.ReadLine()); ;
            Console.WriteLine("the speed of light in a vacuum");
            c = Convert.ToInt32(Console.ReadLine());
            vpow = Math.Pow(v, 2)/ Math.Pow(c, 2);
          
            t0 = t * Math.Sqrt(1-vpow);
            Console.WriteLine("time observed in the other reference frame" + t0+"Us");
            Console.ReadLine();


            }
    }
    }

