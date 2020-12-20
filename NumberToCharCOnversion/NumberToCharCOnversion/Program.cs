using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToCharCOnversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0, r;
            Console.WriteLine("Enter the number :");
            n = Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;
            }
            n = sum;
            while(n>0)
            {
                r = n % 10;

                switch(r)
                {
                    case 1:
                        Console.Write("one");
                        break;
                    case 2:
                        Console.Write("Two");
                        break;
                    case 3:
                        Console.Write("Three");
                        break;
                    case 4:
                        Console.Write("Four");
                        break;
                    case 5:
                        Console.Write("Five");
                        break;
                    case 6:
                        Console.Write("Six");
                        break;
                    case 7:
                        Console.Write("Seven");
                        break;
                    case 8:
                        Console.Write("Eight");
                        break;
                    case 9:
                        Console.Write("Nine");
                        break;
                    case 0:
                        Console.Write("Zero");
                        break;
                    default:
                        Console.Write("pushkar");
                        break;

                        
                }
                n=n / 10;
                Console.ReadKey();

            }
            Console.ReadKey();

        }

    }
}
