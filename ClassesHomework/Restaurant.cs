using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    internal class Restaurant
    {
        public int sushi = 0;
        //public int sushiPrice = 1400;

        public int hotdog = 0;
        //public int hotdogPrice = 450;

        public void MakeSushi(int quantity)
        {
            sushi+=quantity;
            Console.WriteLine($"Here is your sushi!");
        }

        public void MakeHotdog(int quantity)
        {
            sushi+=quantity;
            Console.WriteLine($"Here is your hotdog!");
        }

        public Restaurant()
        {
            
        }

        public Restaurant(int count)
        {
            Menu menu = Menu.afdsdfsdf;
            int result = 0;
            for (int i = 0; i < Enum.GetValues(typeof(Menu)).Length; i++)
            {
                result += (int)menu;
            }
            Console.WriteLine(result);
        }
    }
    public enum Menu
    {
        Sushi = 2000,
        Hotdog = 2344,
        ssdasf = 45679,
        afdsdfsdf = 457,
        sdfsdf = 4567
    }
}
