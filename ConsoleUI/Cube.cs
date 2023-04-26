using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleUI
{
    internal class Cube : Shape
    {
        public double Length { get; set; }

        public Cube(double length)
        {
            this.Name = "Cube";
            this.Length = length;
        }

        public override double Volume()
        {
            return Math.Pow(Length, 3);
        }

        public override void GetInfo()
        {
            base.GetInfo();
            WriteLine($"The Cube has a length of {Length}");
        }
    }
}
