namespace SolidPrinciples.InterfaceSegregation.Bad
{
    public interface IService
    {
        void Add();
        void Update();
        void Delete();
        void UpdateOrderStatus();
        void PackOrder();
    }

    public class OrderService: IService
    {
        public void Add() {} // ...add
        public void Update() {} // ...update
        public void Delete() {} // ...delete

        public void UpdateOrderStatus()
        {
            // ...update order status
        } 

        public void PackOrder()
        {
            // ....(Bad) Order service can not pack order, but it must implement this method
        }
    }
    
    public class WarehouseService: IService
    {
        public void Add() {} // ...add
        public void Update() {} // ...update
        public void Delete() {} // ...delete

        public void UpdateOrderStatus()
        {
            // ....(Bad) Warehouse service can not update order status, but it must implement this method
        }

        public void PackOrder()
        {
            // ...pack order
        }
    }
}