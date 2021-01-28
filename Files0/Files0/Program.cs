using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files0
{
    class Program
    {
        static void Main(string[] args)

        {
            try
            {
                string MyText = "Hello World";
                File.WriteAllText("M:/Programs/FileCSharp/Pushkar.txt", MyText);
                string ReadText = File.ReadAllText(MyText);
                Console.WriteLine(ReadText);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
         
        }
        }
    }

