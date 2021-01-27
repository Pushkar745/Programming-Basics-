using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1
{
    class Vehical //base class(Parent class)
    {
        public string brand = "Ford";
        public void honk()
        {
            Console.WriteLine("Tuut,Tuut!");
        }
    }
    class car:Vehical//derived class(Child)
    {
        public string modelName = "Mustang";

    }
    class Program
    {

        static void Main(string[] args)
        {
            car c = new car();
            c.honk();
            Console.WriteLine(c.brand+""+c.modelName);
            Console.ReadKey();
        }
    }
}
