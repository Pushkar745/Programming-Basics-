using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism0
{
    /* Polymorphism means "many forms"
     
         Why And When To Use "Inheritance" and "Polymorphism"?
- It is useful for code reusability: reuse fields and methods of an existing class when you create a new class.
*/
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("Animal Sound");
        }
    }
    class Dog :Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Bow bOw");
        }
    }
    class Cat:Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Meow");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Dog d = new Dog();
            Cat c = new Cat();
            cat1 c1 = new cat1();
            dog1 d1 = new dog1();
            AnimalSound1 a1 = new AnimalSound1();
            c1.As();
            a1.As();
            d1.As();
                 Console.WriteLine();

            a.animalSound();

            d.animalSound();
            c.animalSound();
            Console.ReadLine();

        }
    }
}
