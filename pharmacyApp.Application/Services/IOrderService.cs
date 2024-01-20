using pharmacyApp.models.Models;

namespace pharmacyApp.Application.Service
{
    public interface IOrderService
    {
        Order AddOrder(Order order);
        void DeleteOrder(Order order);
        IQueryable<Order> GetAllOrders();
        Order GetOrder(int id);
        Order GetOrderName(string name);
        Order UpdateOrder(Order order);
    }
}