using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum0
{
    class Program
    {
        enum Friends{
            Pushkar,
           Manasi,

        }
        static void Main(string[] args)
        {
            Friends f = Friends.Manasi;
            Console.WriteLine(f);
            Console.ReadLine();
        }
    }
}
