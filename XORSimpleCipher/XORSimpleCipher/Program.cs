using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XORSimpleCipher
{
    class Program
    {
        static void Main(string[] args)

        {
//XORSimpleCipher ; 
            char ch1 = 'H';
            char ch2 ='i';
            char ch3 = '!';
            int key = 26;
            Console.WriteLine("original message" + ch1 + ch2 + ch3);
            //Encode the message
            ch1 = (char)(ch1 ^ key);
            ch2 = (char)(ch2 ^ key);
            ch3 = (char)(ch3 ^ key);
            Console.WriteLine("Encoded message" + ch1 + ch2 + ch3);
            //decode The Message
            ch1 = (char)(ch1 ^ key);
            ch2 = (char)(ch2 ^ key);
            ch3 = (char)(ch3 ^ key);
            Console.WriteLine("Decoded message" + ch1 + ch2 + ch3);
            Console.ReadLine();


        }
    }
}
