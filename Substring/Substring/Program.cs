using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Pushkar ";
            string sub = s.Substring(0, 4);
            Console.WriteLine(s);
            Console.WriteLine(sub);
            Console.ReadLine();
        }
    }
}
