using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingDemo
{
    class Program
    {
        class Building
        {
            public int Floors;//Numbers of floors
            public int Area;
            public int Occupants;
        }
        static void Main(string[] args)
        {
            //New is Operator which dynamically allocates memory for an object 
            //allocates at RunTime
            Building house = new Building();//creating house as instance 
            int areaPP;
            house.Occupants = 8;
            house.Area = 2500;
            house.Floors = 2;
            areaPP = house.Area / house.Occupants;
            Console.WriteLine("house has \n" + house.Floors + "floors\n" + house.Occupants + "occupants\n" + house.Area + "total area\n" + areaPP + "area per person");
            Console.ReadLine();
        }
    }
}
