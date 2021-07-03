namespace SolidPrinciples.InterfaceSegregation.Bad
{
    public interface IShipping
    {
        void DomesticShip();
        void InternationalShip();
    }

    public class AirShipping: IShipping
    {
        public void DomesticShip()
        {
            // ....scan
        }

        public void InternationalShip()
        {
            // ....print
        }
    }
    
    public class TruckShipping: IShipping
    {
        public void DomesticShip()
        {
            // ....scan
        }

        public void InternationalShip()
        {
            // ....(Bad) Truck shipping can not ship international, but it must implement this method
        }
    }
}