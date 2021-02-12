using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace StringOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "When it comes to .net programming ,C# is # 1.";
            string str2= "When it comes to .net programming ,C# is # 1.";
            string str3 = "C# string is powerfull.";
            string strupp, strLow;
            int result, idx;
            Console.Write("Strl" + str1);
            Console.Write("Length of Strl 1 is " + str1.Length);
            //create upper and Lowercase version of Strl.
            strLow = str1.ToLower(CultureInfo.CurrentCulture);
            strupp = str2.ToUpper(CultureInfo.CurrentCulture);
            Console.Write("Lower version of Strl is " + strLow);
            Console.Write("Upper verion of Strl is " + strupp);
            Console.WriteLine();
            //Display strl , one char at a time.
            Console.WriteLine("Display strl , one char at a time.");
            for (int i = 0; i < str1.Length; i++)
                Console.WriteLine(str1[i]);
            Console.WriteLine("\n");
            //Compare string using == and != 
            if (str1 == str2)
                Console.WriteLine("str1 == str2");
            else
                Console.WriteLine("str1 !-= str2");
            if(str1==str3)
                Console.WriteLine("str1 == str3");
            else
                Console.WriteLine("str1 !-= str3");
            //This Comparison is Culture Sensitive 
            result = string.Compare(str1, str3, StringComparison.CurrentCulture);
            if (result == 0)
                Console.WriteLine("Str1 and str3 is equal");
            else if (result < 0)
                Console.WriteLine("Str1 is less then str3");
            else
                Console.WriteLine("str1 is greater then str3");
            Console.WriteLine();
            //Assing  a new Stirng to str2;
            str2 = " One Two Three One";
            //Search a string 
            idx = str2.IndexOf("One ", StringComparison.Ordinal);
            Console.WriteLine("Index of first occurrence of one "+idx);
            idx = str2.LastIndexOf("one", StringComparison.Ordinal);
            Console.WriteLine("Index of Last occurrence of one " + idx);
            Console.ReadLine();





        }
    }
}
