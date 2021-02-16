using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSwitch
{
    class Program
    {
        //Use enums when you have values that you know aren't going to change, like month days, days, colors, deck of cards, etc
        enum Level
        {
            Low,
            Medium,
            High
        }
        static void Main(string[] args)
        {
            Level l = Level.High;
            switch(l)
            {
                case Level.Low:
                    Console.WriteLine("Low Level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium Level");
                    break;
                case Level.High:
                    Console.WriteLine("High level");
                    break;
                   
            }
            Console.ReadLine();
        }
    }
}
