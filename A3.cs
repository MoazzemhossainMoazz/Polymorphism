using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class A3: Bmw
    {
        public A3(int hp, string color, string model):base(hp, color, model)
        {

        }
        public override void Repair()
        {
            Console.WriteLine("The Bmw {0} Car was repaired", Model);
        }
    }
}
