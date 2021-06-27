using SolidPrinciples.DependencyInversion.Models;

namespace SolidPrinciples.DependencyInversion.Bad
{
    public class OrderRepository
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
        private readonly OrderRepository _orderRepository;
        
        // (Bad) OrderApplication class depend on OrderRepository class
        public OrderApplication(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public Order GetOrderDetail(int id)
        {
            return _orderRepository.GetOrderDetail(id);
        }
    }
}