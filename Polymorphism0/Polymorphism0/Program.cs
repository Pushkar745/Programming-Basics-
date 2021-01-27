using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism0
{
    class Animal
    {
        public void animalSound()
        {
            Console.WriteLine("Animal Sound");
        }
    }
    class Dog :Animal
    {
        public void dogsound()
        {
            Console.WriteLine("Bow bOw");
        }
    }
    class Cat:Animal
    {
        public void catSound()
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
            a.animalSound();
            Console.WriteLine();
            d.dogsound();
            c.catSound();
            Console.ReadLine();

        }
    }
}
