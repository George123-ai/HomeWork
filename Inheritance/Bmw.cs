namespace Inheritance
{
    public class Bmw : Car
    {
        public Bmw() : base()
        {
            Color = "Red";
        }

        public Bmw(string Color, int MaxSpeed)
        {
            //MinSpeed = minSpeed;
            this.Color = Color;
            this.MaxSpeed = MaxSpeed;
        }

    }
}
