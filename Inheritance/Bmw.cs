using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bmw:Car
    {
        public Bmw() : base()
        {
            Color = "Red";
            
        }

        public Bmw(string Color, int MaxSpeed): base()
        {
            //MinSpeed = minSpeed;
            this.Color = Color;
            this.MaxSpeed = MaxSpeed;
        }

    }
}
