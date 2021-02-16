using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharAndBoolType
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = 'm';
            Console.WriteLine("char is " + ch);
            bool b;
            b = false;
            Console.WriteLine("b is" + b);
            b = true;
            Console.WriteLine("b is " + b);
            //A Bool Value can Control the if Statement
            if (b) Console.WriteLine("This is executed");
            b = false;
            if (b) Console.WriteLine("This is not executed");
            //OutCome of a relational operator is a bool value.
            Console.WriteLine("10>9 is " + (10 > 9));
            Console.ReadKey();
            /*Some OutPut Options (Sophisticated formating mechanism) 
             WriteLine("Formating string " , arg0,arg1,....argN);
             The formate string contains two items:regular ,printing char are displayed as-is and formate specifiers
             {argnum,width:fmt)
             */

            Console.WriteLine("November has {0,10} or {1,5} days.", 28, 31);
            int i;
            Console.WriteLine("value\tSquared\tCubed");
            for (i = 1; i <= 10; i++)
                Console.WriteLine("{0}\t{1}\t{2}", i, i * i, i * i * i);
            Console.ReadKey();
        }
    }
}
