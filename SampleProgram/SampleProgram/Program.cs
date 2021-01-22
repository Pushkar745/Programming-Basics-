using System;


namespace SampleProgram
{
    class Program
    {
            
        static void Main(string[] args)
        {
            int n,i;
            Console.WriteLine("Enter the range");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= n; i++) Console.WriteLine("The range is " + i);

            Console.ReadKey();
            /* 
             let N=0;
             For Each pair of people in room
             set n=n+1;
             */
        }
        
    }
}
