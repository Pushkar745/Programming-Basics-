using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sample = new int[12];

            int i;
            for (i = 0; i <= 10; i=i+1)
                sample[i] = i;
            for(i=0;i<=10;i=i+1)
            Console.WriteLine("Sample" + i +  " Array Value" + sample[i]);
            Console.ReadKey();
        }
    }
}
