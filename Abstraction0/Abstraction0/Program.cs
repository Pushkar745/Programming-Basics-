using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction0
{
   abstract class Animal
    {

        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Animal Sound");
        }
    }
    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("Bow bOw");
        }
    }
    class Cat : Animal
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
            Dog d = new Dog();
            d.animalSound();
            Console.ReadLine();
        }
    }
}
