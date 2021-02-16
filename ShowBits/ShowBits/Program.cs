using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowBits
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display The bits within a byte
            int t;
            byte val;
            ushort num;
            ushort i;
            val = 123;
            Console.WriteLine(val);
            for(t=128;t>0;t=t/2)
            {
                if ((val & t) != 0) Console.Write("1 ");
            }
            if ((val & t) == 0) Console.Write("0 ");
            for(i=1;i<=10;i++)
            {
                num = i;
                Console.WriteLine("num: " + num);
                num = (ushort)(num | 1);
                Console.WriteLine("num after turing on bit zero :" + num + "\n");
            }
            Console.ReadLine();
        }
       
    }
}
