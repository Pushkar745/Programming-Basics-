using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachArraySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[12];
            int val;
            bool found = false;
            //Give Nums some value
            for (int i = 0; i < 10; i++)
                num[i] = i;
            val = 5;
            //Use foreach to serach nums for key
            foreach(int x in num)
            {
                if(x==val)
                {
                    found = true;
                    break;
                }
            }
            if (found)
                Console.WriteLine("Value found");
            Console.ReadLine();
        }
    }
}
