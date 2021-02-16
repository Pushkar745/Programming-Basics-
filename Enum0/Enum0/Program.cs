using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum0
{
    //Enum is short for "enumerations", which means "specifically listed"
    class Program
    {
        enum Friends{
            Pushkar,//Enum inside a Class
            Manasi,
           ABC=8,//You can also assign your own enum values,
            XYZ
        }
        static void Main(string[] args)
        {
            Friends f = Friends.Manasi;
            int f1 = (int)Friends.Manasi;//Enum Values
            int f2 = (int)Friends.ABC;

            Console.WriteLine(f);
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.ReadLine();
        }
    }
}
