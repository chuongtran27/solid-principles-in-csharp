namespace SolidPrinciples.LiskovSubstitution.Good
{
    abstract class Shipping
    {
        public virtual void Ship()
        {
        }
    }

    class AirShipping : Shipping
    {
        public override void Ship()
        {
            //...ship
        }
    }

    class TruckShipping : Shipping
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
            // (Good) AirShipping and TruckShipping can be a replacement for Shipping base class
            Shipping airShipping = new AirShipping();
            airShipping.Ship();
            Shipping truckShipping = new TruckShipping();
            truckShipping.Ship();
        }
    }
}