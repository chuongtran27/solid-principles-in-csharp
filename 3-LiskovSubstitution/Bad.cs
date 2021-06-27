namespace SolidPrinciples.LiskovSubstitution.Bad
{
    class AirShipping
    {
        public virtual void Ship()
        {
            //...ship
        }
    }

    class TruckShipping : AirShipping
    {
        public override void Ship()
        {
            //...ship
        }
    }

    internal class Program
    {
        public static void Execute()
        {
            // (Bad) AirShipping can not be replaced by TruckShipping. It affects correctness of the application
            AirShipping airShipping = new TruckShipping();
            airShipping.Ship();
        }
    }
}