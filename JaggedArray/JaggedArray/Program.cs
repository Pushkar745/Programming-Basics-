using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] j = new int [3][];
            j[0] = new int[4];
            j[1] = new int[3];
            j[2] = new int[5];
            int i;
            for (i = 0; i < 4; i++)
                j[0][i] = i;
            for (i = 0; i < 3; i++)
                j[1][i] = i;
            for (i = 0; i < 5; i++)
                j[2][i] = i;
            for (i = 0; i < 4; i++)
                Console.Write(j[0][i] + "");
            Console.WriteLine();
            for (i = 0; i < 3; i++)
                Console.Write(j[1][i] + "");
            Console.WriteLine();
            for (i = 0; i < 5; i++)
                Console.Write(j[2][i] + "");
            Console.WriteLine();
            Console.ReadLine();


        }
    }
}
