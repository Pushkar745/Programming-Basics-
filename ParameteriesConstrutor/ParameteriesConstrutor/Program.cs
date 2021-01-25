using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameteriesConstrutor
{
    class Program
    { 

       protected string model;
    public string color;
    public int year;
        public Program(string modelName, string modeColor, int modelYear)
        {
            model = modelName;
            color = modeColor;
            year = modelYear;

        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

            static void Main(string[] args)
        {
            Program p = new Program("Mustang","red",1995);
            p.Name = "pushkar";
            Console.WriteLine(p.name);

            Console.WriteLine(p.color + "" + p.year + "" + p.model);
            Console.ReadLine();
        }
    }
}
