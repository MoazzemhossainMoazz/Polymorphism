using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Bmw(200, "Red", "A3"),
                new Audi(100, "blue", "Z3")
            };

            foreach(var car in cars)
            {
                car.Repair();
            }

            A3 a3 = new A3(260, "grey", "a3001");
            a3.ShowDetails();
            Console.ReadKey(); 
        }
    }
}
