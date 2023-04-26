using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleUI
{
    internal class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            this.Name = "Sphere";
            this.Radius = radius;
        }

        public override double Volume()
        {
            return Math.PI * (Math.Pow(Radius, 3)) * 4 / 3;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            WriteLine($"The Sphere has a Radius of {Radius}");
        }
    }
}
