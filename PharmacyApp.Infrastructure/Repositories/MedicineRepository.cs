using Microsoft.EntityFrameworkCore;
using pharmacyApp.Application.Contract;
using pharmacyApp.models.Models;
using PharmacyApp.Context.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp.Infrastructure.Repositories
{
    public class MedicineRepository : Repository<Medicincs, int>,IMedicincs
    {
        protected AppDbContext _context;
        public MedicineRepository(AppDbContext context)
            : base(context)
        {
         _context = context;
       
        
        }

        public ProducingCompany GetProducingCompany(int MedicineId)
        {
            Medicincs Medicine = AppDbContext.Medicincs.Where(M => M.Id == MedicineId).FirstOrDefault();
            return (Medicine.ProducingCompany != null)?Medicine.ProducingCompany:new ProducingCompany();

        }
        private AppDbContext AppDbContext
        {
            get { return _context as AppDbContext; }
        }

    }
}
