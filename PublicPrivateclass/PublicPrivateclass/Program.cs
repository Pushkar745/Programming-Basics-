using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicPrivateclass
{
    class MyClass
    {
        private int alpha;
        int beta;
        public int gamma;
        public void SetAlpha(int a)
        {
            alpha = a;
        }
        public int GetAlpha()
        {
            return alpha;
        }
        public void SetBeta(int a)
        {
            beta = a;

        }
        public int GetBeta()
        {
            return beta;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass ob = new MyClass();
            //Access to alpha and beta is allowed only through methods
            ob.SetAlpha(55);
            ob.SetBeta(21);
            Console.WriteLine("ob.alpha is " + ob.GetAlpha());
            Console.WriteLine("Ob.Beta is " + ob.GetBeta());
            //You can not access alpha or beta like this 
            //ob.alpha = 10;\
            //It is OK to directly access gamma because it is public
            ob.gamma = 99;
            Console.ReadLine();
        }
    }
}
