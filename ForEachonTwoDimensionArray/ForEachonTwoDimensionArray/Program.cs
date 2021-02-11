using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachonTwoDimensionArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[,] nums = new int[3, 5];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 5; j++)
                    nums[i, j] = (i + 1) * (j + 1);
            foreach (int x in nums)
            {
                Console.WriteLine("Value is: " + x);
                sum += x;
            }
            Console.WriteLine("Summation: " + sum);
            Console.ReadLine();
        }
    }
}
