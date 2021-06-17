using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance1a
{
class TwoDshape
    {
        public double Width;
        public double Height;
        public void ShowDim()
        {
            Console.WriteLine("Width an Height are " + Width + "and" + Height );
        }
    }
    class Triangle : TwoDshape
    {
        public string Style;
        public double Area()
        {
            return Width * Height / 2;

        }
        public void ShowStyle()
        {
            Console.WriteLine("Triangle is " + Style);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle();
            Triangle t2 = new Triangle();
            t1.Width = 5.2;
            t1.Height = 5.2;
            t1.Style = "isosceles";
            t2.Width = 8.0;
            t2.Height = 12.0;
            t2.Style = "right";
            Console.WriteLine("Info for t1 :");
            t1.ShowStyle();
            t1.ShowDim();
            Console.WriteLine("Area is : " + t1.Area());
            Console.WriteLine();
            Console.WriteLine("Info for t2 :");
            t2.ShowDim();
            t2.ShowStyle();
            Console.WriteLine("Area is " + t2.Area());
            Console.ReadKey();


        }
    }
}
