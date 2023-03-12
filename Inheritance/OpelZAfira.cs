using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class OpelZAfira: Opel
    {
        public OpelZAfira() : base()
        {
            Model = "Zafira";
        }

        public override void OpelStart()
        {
            Console.WriteLine("My opel Zafira starts!");
        }

        public override void PrintData()
        {
            base.PrintData();
            Console.WriteLine($"Model: {Model}");
        }
    }
}
