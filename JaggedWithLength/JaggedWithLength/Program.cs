using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedWithLength
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] j = new int[5][];
            j[0] = new int[3];
            j[1] = new int[7];
            j[2] = new int[2];
            j[3] = new int[5];
            int i, k;
            try
            {
                for (i = 0; i < j.Length; i++)
                for (k = 0; k < j.Length; k++)
                    j[i][k] = i + k ;
            Console.Write("The total number of Nodes :" + j.Length + "\n");
          
                for (i = 0; i < j.Length; i++)
                {
                    for (k = 0; k < j[i].Length; k++)
                    {
                        Console.Write("CPU Usage at Node " + i + "CPU" + k + ":");
                        Console.Write(j[i][k] + "%");

                    }
                    Console.WriteLine();
                }
            }
            catch(Exception e) {
                Console.WriteLine(e.Message);
            }
                Console.ReadLine();
            

        }
    }
}
