using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeDimensionalArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] a = new int[5,5,5];
            int sum = 0;
            int n = 1;
            for (int x = 0; x < 5; x++)
                for (int y = 0; y < 5; y++)
                    for (int z = 0; z < 5; z++)
                        a[x, y, z] = n++;
            sum = a[0, 0, 0] + a[1, 1, 1] + a[2, 2, 2];
            Console.WriteLine("Sum of first diagonal" + sum);
            Console.ReadLine();

        }
    }
}
