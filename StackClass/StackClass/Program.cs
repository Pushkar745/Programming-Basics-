using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackClass
{
    //A Stack class for Char
    class Stack
    {
        //These member are private
        char[] stck; //Hold the stack
        int tos;//indesx of the stack
        public Stack (int size)//construtor
        {
            stck = new char[size];
            tos = 0;//allocate memory for stack
        }
        //push Char onto the stack
        public void Push(char ch)
        {
            if(tos==stck.Length)
            {
                Console.WriteLine("--Stack is full");
                return;
            }
            stck[tos] = ch;
            tos++;
        }
        //Pop a char from the stack
        public char Pop()
        {
            if(tos==0)
            {
                Console.WriteLine("-- stack is empty");
                return (char)0;
            }
            tos--;
            return stck[tos];
        }
        //retuen true if the stack is full
        public bool IsFull()
        {
            return tos == stck.Length;
        }
        public bool IsEmpty()
        {
            return tos == 0;

        }
        public int Capacity()
        {
            return stck.Length;
        }
        public int GetNum()
        {
            return tos;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack s1 = new Stack(10);
            Stack s2 = new Stack(10);
             Stack s3 = new Stack(10);
            char ch;
            int i;
            Console.WriteLine("Push A through J into s1");
            for (i = 0; !s1.IsFull(); i++)
                s1.Push((char) ('A' + i));
            if (s1.IsFull())
                Console.WriteLine("s1 is full");
            Console.Write("Contents of s1 ");
            while(!s1.IsEmpty())
                {
                ch = s1.Pop();
                Console.Write(ch);
            }
            Console.WriteLine();
            if (s1.IsEmpty()) Console.WriteLine("s1 is Empty \n");
            //put more Char into s1
            Console.WriteLine("Again Push A through J onto s1");
            for (i = 0; !s1.IsFull(); i++)
                s1.Push((char)('A' + i));
            Console.WriteLine("Now,pop chars from s1 and push" + "them onto s2.");
            while (!s1.IsEmpty())
            {
                ch = s1.Pop();
                s2.Push(ch);
            }
            Console.Write("Contents of s2 :");
            while (!s2.IsEmpty())
            {
                ch = s2.Pop();
                s2.Push(ch);
                Console.Write(ch);
            }
            Console.WriteLine();
            Console.WriteLine("Put 5 chars on to s3");
            for (i = 0; i < 5; i++)
                s3.Push((char)('A' + i));
            Console.WriteLine("Capacity of s3 :" + s3.Capacity());
            Console.WriteLine("Number of Objects in s3 " + s3.GetNum());
            Console.ReadLine();
        }
    }
}
