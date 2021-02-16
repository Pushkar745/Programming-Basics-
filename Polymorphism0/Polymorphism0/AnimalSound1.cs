using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism0
{
    class AnimalSound1
    {

        public  void As()
        {
            Console.WriteLine("Sound of cat and Dog");
        }
    }
    class cat1:AnimalSound1
    {
        public  void As()
        {
            Console.WriteLine("Mewo");
            
        }

    }
    class dog1 : AnimalSound1
    {
        public  void As()
        {
            Console.WriteLine("Bow Bow");
        }
    }
    //Not the output i was looking for
    //That is because the base class method overrides the derived class method, when they share the same name.
    //by adding the virtual keyword to the method inside the base class,
    //and by using the override keyword for each derived class methods
}
