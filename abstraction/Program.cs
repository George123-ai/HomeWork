namespace abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("car");
            car.Move();

            Motorcycle motorcycle = new Motorcycle("Moto");
            motorcycle.Move();

        }
    }
}