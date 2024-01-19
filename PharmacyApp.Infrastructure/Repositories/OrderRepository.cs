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
    internal class OrderRepository:Repository<Order,int>,IOrder
    {

        public OrderRepository(AppDbContext context)
           : base(context)
        { }
  
        

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
