using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Task3
{
    public abstract class Shape
    {
        public string Name { get; set; }

        public Shape(string name)
        {
            Name = name;
        }

        public virtual void Display()
        {
            Console.WriteLine($"Shape: {Name}");
        }
    }
}
