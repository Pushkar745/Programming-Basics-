using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface0
{
    interface Employee
    {
        void Name();
    }

    class Acenture:Employee
    {
        public  void Name()
        {
            Console.WriteLine("Pushkar");
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Acenture a = new Acenture();
            a.Name();
        }
    }
}
