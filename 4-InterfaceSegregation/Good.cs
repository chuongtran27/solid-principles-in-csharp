namespace SolidPrinciples.InterfaceSegregation.Good
{
    public interface IInternationalShip
    {
        void InternationalShip();
    }
    
    public interface IDomesticShip
    {
        void DomesticShip();
    }

    public class AirShipping: IDomesticShip, IInternationalShip
    {
        public void DomesticShip()
        {
            // ....ship
        }

        public void InternationalShip()
        {
            // ....ship
        }
    }
    
    // (Good) Separate interface help low-level modules only implement interfaces that they need
    public class TruckShipping: IDomesticShip
    {
        public void DomesticShip()
        {
            // ....print
        }
    }
}