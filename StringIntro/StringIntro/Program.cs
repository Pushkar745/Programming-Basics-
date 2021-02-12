using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace StringIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charray = { 'p', 'u', 's', 'h', 'k', 'a', 'r' };
            string str1 = "I Love Prrogramming";
            string s = str1.ToUpper();
            Console.WriteLine(charray.Length);
            Console.WriteLine(s);
            Console.WriteLine(str1);
            Console.ReadLine();
        }
    }
}
