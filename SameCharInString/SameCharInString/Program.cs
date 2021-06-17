using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SameCharInString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string");
            string InputString = Console.ReadLine();
            while(InputString.Length>=0)
            {
                int Charcount = 0;
                try
                {
                    Console.Write($"{InputString[0]}");

                    for (int i = 0; i < InputString.Length; i++)
                    {
                        if (InputString[0] == InputString[i])
                        {
                            Charcount++;
                        }
                    }


                    Console.WriteLine($"{Charcount}");
                    InputString = InputString.Replace(InputString[0].ToString(), string.Empty);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();

            }
        }

    }
}
