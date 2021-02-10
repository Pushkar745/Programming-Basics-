using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreachloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] nums = new int[12];
            //Give nums some values
            for (int i = 0; i <= 10; i++)
                nums[i] = i;
            //Use foreach to display and sum the values
            foreach(int x in nums)
            {
                Console.WriteLine("Value is :" + x);
                sum += x;

                if (x == 4) break;
            }
         
            Console.WriteLine("Summation: " + sum);
            Console.ReadLine();
        }
    }
}
