using System.Diagnostics.CodeAnalysis;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 12.123;
            double num2 = 14.456;
            double sum = num1 + num2;

            float somenum = 456.345f;
            float somenum1 = somenum;
            float division = somenum / somenum1;

            decimal money = 1000;

            //Console.WriteLine("First number = " + num1);
            //Console.WriteLine("Second number = " + num2);
            //Console.WriteLine("Sum = " + sum);

            //Console.WriteLine(division);

            //Console.WriteLine("You have " + money + "$");

            int age = 19;

            bool permission = age > 18;

            if (permission) 
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            age = 15;
            string permission1 = age > 18 ? "true" : "false";

            Console.WriteLine(permission1);
            
        }
    }
}