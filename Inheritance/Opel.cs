using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Opel:Car
    {
        public Opel() : base()
        {
            Brand = "Opel";
        }

        public virtual void OpelStart()
        {
            Console.WriteLine("Opel start!"); 
        }

        public override void PrintData()
        {
            base.PrintData();
            Console.WriteLine($"Brand: Opel");
        }
    }
}
