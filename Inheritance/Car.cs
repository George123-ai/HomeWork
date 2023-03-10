using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Car
    {
        private int MinSpeed { get; } 

        public string Color { get; set; }

        protected int MaxSpeed { get; set; }

        public Car() 
        {
            MinSpeed = 0;
            Color = "black";
            MaxSpeed = 400;

        }

        public Car(string Color, int MaxSpeed)
        {
            //this.MinSpeed = MinSpeed;
            this.Color = Color;
            this.MaxSpeed = MaxSpeed;
        }

        public void PrintData()
        {
            Console.WriteLine($"Min speed = {MinSpeed}km/h \nMax speed = {MaxSpeed}km/h \nDefault color is {Color}");
        }
    }
}
