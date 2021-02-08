using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOfArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            int[] n1 = new int[10];
            int[] n2 = new int[10];
            for (i = 0; i < n1.Length; i++) n1[i] = i; //init array
            Console.WriteLine("Original Contents");
            for (i = 0; i < n2.Length; i++)
                Console.WriteLine(n1[i] + ""); //display array 
            Console.WriteLine();
            //Reverse
            if (n2.Length >= n1.Length)
                for (i = 0, j = n1.Length - 1; i < n1.Length; i++, j--)
                    n2[j] = n1[i];
            Console.Write("Reversed Contents:");
            for (i = 0; i < n2.Length; i++)
                Console.Write(n2[i] + "");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
