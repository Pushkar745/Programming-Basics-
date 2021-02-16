using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisKeyword
{
    class Program
    {
        class Rect
        {
            public int Width;
            public int Height;
            public Rect(int w ,int h)
            {
                this.Width = w;
                this.Height = h;
            }
            public int Area()
            {
                return this.Width * this.Height;
            }
        }
        static void Main(string[] args)
        {
            Rect r1 = new Rect(8, 5);
            Rect r2 = new Rect(6, 2);
            Console.WriteLine("Area of r1"+r1.Area());
            Console.WriteLine("Area of r2 " + r2.Area());
            Console.ReadLine();
        }
    }
}
