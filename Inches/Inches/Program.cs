using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches
{
    class Program
    {
        static void Main(string[] args)
        {
            //Compute the distance from the earth to the sun ,in imches
            long inches; //width in bits 64 
            long miles;
            miles = 93000000; // 93,000,000 miles to the sun 
            inches = miles * 5280 * 12;
            Console.WriteLine("Distance to the sun " + inches + "inches.");
            Console.ReadKey();
            // the program use long veriable to hold it 
            Console.WriteLine();
            //The smallest integers type are byte and sbyte . The Byte is unasigned value between  and 250
            byte x;
            int sum = 0;
            for (x = 1; x <= 100; x++)
                sum = sum + x;
            Console.WriteLine("Summation of 100" + sum);
            Console.ReadKey();
        }
    }
}
