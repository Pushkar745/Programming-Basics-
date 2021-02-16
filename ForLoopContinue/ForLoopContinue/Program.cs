using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0;i<=100;i++)
            {
                if ((i % 2) != 0) continue;//iterate 
                Console.WriteLine(i+i);
                Console.ReadLine();
                //only even Numbers are printed because an odd number will cause the loop to iterate early,Bypassing the call to WriteLine()
            }
        }
    }
}
