using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoTOStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1;i<5;i++)
            {
                switch(i)
                {
                    case 1:
                        Console.WriteLine("Incase 1");
                        goto case 3;
                    case 2:
                        Console.WriteLine("in CASE 2");
                        goto case 1;
                    case 3:
                        Console.WriteLine("In Case 3");
                        goto case 2;
                    default:
                        Console.WriteLine("In Default");
                        break;

                }
                Console.WriteLine();
//Console.ReadLine();
            }
        }
    }
}
