using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorDemo
{
    class Program
    {
        class Destruct
        {
            public int x;
            public Destruct(int i)
            {
                x = i;
            }

            ~Destruct()
            {
                Console.WriteLine("Destructing " + x);
            }
            //Generate an object that is immediately destroyed
            public void Generator(int i)
            {
                Destruct o = new Destruct(i);
            }
        }
        //called when object is recycled
       
        static void Main(string[] args)
        {
            int count;
            Destruct ob = new Destruct(0);
            /* Now ,Generate a large number of object .Atsome point,Garbage collection will occur.
             Note: You might need to increase the numeber of objects generated in order to force garbage collection
             */
            for (count = 1; count < 100000; count++)
                ob.Generator(count);
            Console.WriteLine("Done!");
            Console.ReadLine();

        }
    }
}
