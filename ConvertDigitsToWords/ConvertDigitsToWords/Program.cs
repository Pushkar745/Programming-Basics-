using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertDigitsToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int nextdigit;
            int numdigits;
            int[] n = new int[21];
            string[] d = {"Zero","one","two","three","four","five","six","seven","eight","nine" };
            num = 745;
            Console.WriteLine("Numeber " + num);
            Console.Write("Number in words");
            nextdigit = 0;
            numdigits = 0;
            //get Individual digits and store in n 
            //These digits stored in reverse order
            do
            {
                nextdigit = num % 10;
                n[numdigits] = nextdigit;
                numdigits++;
                num = num / 10;

            } while (num > 0);
            numdigits--;
            //display the words
            for(; numdigits>=0;numdigits--)
                Console.Write(d[n[numdigits]] +"");
            Console.WriteLine();
            Console.ReadLine();


        }
    }
}
