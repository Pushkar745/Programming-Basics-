using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            int fno=0,cno=1,b=2,tno,fib;
            Console.WriteLine("Enter the limit upto to display fibonacci");
            fib=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(fno);
            Console.WriteLine(cno);
            for(;b<= fib;b++)
                {
             tno=fno+cno;
            Console.WriteLine(tno);
            fno=cno;
            cno=tno;
        }
    Console.ReadKey();
    }
    
}
    }
