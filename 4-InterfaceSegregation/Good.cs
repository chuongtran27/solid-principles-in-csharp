namespace SolidPrinciples.InterfaceSegregation.Good
{
    public interface IBaseService
    {
        void Add();
        void Update();
        void Delete();
    }

    // (Good) Separate interface help high-level modules only implement interfaces that they need
    public interface IOrderService : IBaseService
    {
        void UpdateOrderStatus();
    }

    public class OrderService: IOrderService
    {
        public void Add() {} // ...add
        public void Update() {} // ...update
        public void Delete() {} // ...delete

        public void UpdateOrderStatus()
        {
            // ...update order status
        }
    }
    
    public interface IWarehouseService : IBaseService
    {
        void PackOrder();
    }
    
    public class WarehouseService: IWarehouseService
    {
        public void Add() {} // ...add
        public void Update() {} // ...update
        public void Delete() {} // ...delete

        public void PackOrder()
        {
            // ...pack order
        }
    }
}