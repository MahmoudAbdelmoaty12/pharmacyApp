using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using pharmacyApp.Application.Contract;
using pharmacyApp.models.Models;
using PharmacyApp.Context.Context;

namespace PharmacyApp.Infrastructure.Repositories
{
    public class producingCompanyRepository : Repository<ProducingCompany, int>, IProducingCompany
    {

        public producingCompanyRepository(AppDbContext context) : base(context)
        {

        }

        public IQueryable< ProducingCompany> GetProducingCompany(int MedicineId)
        {
            var medicincs = _context.Set<Medicincs>().Where(p => p.Id == MedicineId).FirstOrDefault();

            return  _context.Set<ProducingCompany>().Where(p => p.Medicincs.Contains(medicincs));




        }
    }
}
