using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[12];
            int avg = 0;
            num[0] = 99;
            num[1] = 10;
            num[2] = 100;
            num[3] = 18;
            num[4] = 78;
            num[5] = 23;
            num[6] = 63;
            num[7] = 9;
            num[8] = 87;
            num[9] = 49;
            for (int i = 0; i <= 10; i++)
                avg = avg + num[i];
            avg = avg / 10;
            Console.WriteLine("Average: " + avg);
            Console.ReadLine();


        }
    }
}
