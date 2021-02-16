using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        /* Point To rember 
         1) It Cannot have return type(Like void or int)
         2) construtor is called when the object is created 
         3) All classes have Construtor by default
         4)Construtors save time! 
             
             */

        public string model; //field
        public Program() //class Construtor
        {
            model = "Mustang"; //initial value
        }
        static void Main(string[] args)
        {
            Program p =new Program(); //Object criations (this will call The Construtor 
            Console.WriteLine(p.model); //print the value 
            Console.ReadLine();
        }
    }
}
