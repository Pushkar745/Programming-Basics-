using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLengthProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            Console.WriteLine("Length of Nums " + nums.Length);
            for (int i = 0; i < nums.Length; i++)
                nums[i] = i * i;
            Console.WriteLine("Here is NUms");
            for (int i = 0; i < nums.Length; i++)
                Console.WriteLine(nums[i] + "");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
