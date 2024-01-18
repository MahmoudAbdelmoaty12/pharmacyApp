using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pharmacyApp.models.Models;

namespace pharmacyApp.Application.Contract
{
    internal interface IOrder:IRepository<Order,int>
    {
    }
}
