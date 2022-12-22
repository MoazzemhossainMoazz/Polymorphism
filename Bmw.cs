using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Bmw: Car
    {
        private string brand = "bmw";
        public string Model { get; set; }

        public Bmw(int hp, string color, string model):base(hp,color)
        {
            //this.HP = hp;
            //this.Color = color;
            this.Model = model;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Brand: " + brand + " " +"HP: "+ HP + "Color: " + Color);
        }
        public override void Repair()
        {
            Console.WriteLine("The Bmw {0} Car was repaired", Model);
        }
    }
}
