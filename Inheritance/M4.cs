namespace Inheritance
{
    public class M4 : Bmw
    {
        public int Price { get; set; }  


        public M4() : base()
        {
            Model = "m4";
            //Color = "Dark green";
            MaxSpeed = 295;
            Price = 100000;
        }

        public override void PrintData()
        {
            base.PrintData();
            Console.WriteLine($"model: {Model}\nprice = {Price}$");
        }

        public M4(string color, int maxSpeed) : base(color, maxSpeed)
        {

        }

    }
}
