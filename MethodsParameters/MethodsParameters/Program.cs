using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsParameters
{
    class Program
    {
        static void Mymethod(string Myname)//When a parameter is passed to the method, it is called an argument.
        {
            Console.WriteLine(Myname + "\tbaviskar");

        }
        static void Nmethod(string name = "Manasi")//A parameter with a default value, is often known as an "optional parameter"
        {
            Console.WriteLine(name);
        }
        static void Main(string[] args)
        {/* Information can be passed to methods as parameter.
            Parameters act as variables inside the method.
            They are specified after the method name, inside the parentheses. 
            You can add as many parameters as you want, just separate them with a comma.
            The following example has a method that takes a string called fname as parameter. */
            Mymethod("Pushkar");
            Nmethod();
            Console.ReadLine();
        }
    }
}
