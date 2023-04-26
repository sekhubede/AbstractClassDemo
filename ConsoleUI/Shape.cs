using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleUI
{
    // abstract, means that this class cannot be instantiated.
    // objects of this class cannot be created.
    abstract class Shape
    {
        public string Name { get; set; }

        public virtual void GetInfo()
        {
            WriteLine($"\nThis is a {Name}");
        }

        // volume method not implemented.
        // indicates that the deriving classes should implement
        // a functionality for a Volume method.
        public abstract double Volume();
    }
}
