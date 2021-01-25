using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMembers
{
    class Program
    {
        class MyClass

        {

            //Fields and methods inside classes are often referred to as "Class Members":
            string Name = "Pushkar"; //field
            int Salary = 5000000;//field
            int Age=27;
            public void Job(string age="27") //Method
            {
                Console.WriteLine("My name is :" + Name);
                Console.WriteLine("My Salary:"+Salary);
                Console.WriteLine(age);
            }
        }
       
        static void Main(string[] args)
        {
            MyClass p = new MyClass();
            p.Job();
           
            Console.ReadLine();

        }
    }
}
