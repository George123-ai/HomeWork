namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.PrintData();

            car.Color = "Green";
            car.PrintData();

            Car car1 = new Car("Gray", 200);
            car1.PrintData();

            Console.WriteLine();

            Bmw bmw1 = new Bmw();
            bmw1.PrintData();

            Console.WriteLine();
            Console.WriteLine("-------------------------------------");

            Bmw bmw2 = new Bmw("red", 100);
            bmw2.PrintData();

            M4 bmwM4 = new M4("Purple", 300);
            bmwM4.PrintData();

        }
    }
}