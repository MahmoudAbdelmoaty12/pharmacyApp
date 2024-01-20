using pharmacyApp.Application.Contract;
using pharmacyApp.models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacyApp.Application.Service
{
    public class OrderService : IOrderService
    {
        IOrder _order;

        public OrderService(IOrder order)
        {
            _order = order;
        }

        public Order AddOrder(Order order)
        {
            var add = _order.Add(order);
            _order.Save();
            return add;
        }
        public Order GetOrder(int id)
        {
            return _order.GetById(id);
        }
        public IQueryable<Order> GetAllOrders()
        {
            return _order.GetAll();
        }

        public void DeleteOrder(Order order)
        {
            _order.Delete(order);
            _order.Save();
        }

        public Order UpdateOrder(Order order)
        {

            var delete = _order.Update(order);
            _order.Save();
            return delete;
        }
        public Order GetOrderName(string name)
        {
            return _order.GetByName(name);
        }



    }
}
