using pharmacyApp.models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacyApp.Application.Contract
{
    public interface IMedicincs:IRepository<Medicincs,int>
    {
        public ProducingCompany GetProducingCompany(int MedicineId);
        public bool IsMedicineValid(Medicincs medicincs);
     
    }
}
