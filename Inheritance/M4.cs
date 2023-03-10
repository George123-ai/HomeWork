namespace Inheritance
{
    public class M4 : Bmw
    {
        public M4() : base()
        {
            Color = "Dark green";
            MaxSpeed = 295;
        }

        public M4(string color, int maxSpeed) : base(color, maxSpeed)
        {

        }

    }
}
