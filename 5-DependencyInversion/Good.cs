using SolidPrinciples.DependencyInversion.Models;

namespace SolidPrinciples.DependencyInversion.Good
{
    public interface IOrderRepository
    {
        Order GetOrderDetail(int id);
    }

    public class OrderRepository : IOrderRepository
    {
        public Order GetOrderDetail(int id)
        {
            return new Order()
            {
                Id = id,
                Items = new[] {"Book", "Toothpaste"},
                TotalAmount = 10000
            };
        }
    }

    public class OrderApplication
    {
        private readonly IOrderRepository _orderRepository;
        public OrderApplication(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        
        // (Good) Create abstract IOrderRepository interface
        // High-level modules doesn't need to know about implementation of low-level modules.
        // OrderApplication just depend on abstract interface IOrderRepository.
        public Order GetOrderDetail(int id)
        {
            return _orderRepository.GetOrderDetail(id);
        }
    }

}