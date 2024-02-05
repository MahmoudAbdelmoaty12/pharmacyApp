using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pharmacyApp.Application.Contract;
using pharmacyApp.models.Models;
using PharmacyApp.Context.Context;

namespace PharmacyApp.Infrastructure.Repositories
{
    public class OrderRepository:Repository<Order,int>,IOrder
    {

        public OrderRepository(AppDbContext context)
           : base(context)
        { }

        public Order UpdateStatus(Order order, OrderStatus orderStatus)
        {
            try
            {
                var res = _context.Orders.Where(or => or.Id == order.Id).SingleOrDefault();
                res.Status = orderStatus;
                _context.SaveChanges();
                return res;
            }
            catch (Exception ex) 
            {
                return null;
            }
           
        }



        //public Medicincs AddOne(Medicincs medicincs)
        //{
        //  return  _context.Add(medicincs).Entity;
        //}

        //public Medicincs RemoveOne(Medicincs medicincs)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
