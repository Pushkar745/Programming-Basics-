using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMissingPiecesAndMoveInit
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
                for(i=0;i<10;)
            {
                Console.WriteLine("Pass #" + i);
                i++; //increment loop control var 

                Console.ReadLine();
            }
            i = 0; // move init out of loop
                for(;i<20;)
            {
                Console.WriteLine("pass #" + i);
                i++;//increment loop control var
                Console.ReadLine();

            }
        }
    }
}
