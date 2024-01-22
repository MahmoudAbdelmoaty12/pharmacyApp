using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pharmacyApp.models.Models;

namespace pharmacyApp.Application.Services
{
    public interface IProducingCompanyService
    {

        ProducingCompany AddCompany(ProducingCompany producingCompany);
        ProducingCompany UpdateCompany(ProducingCompany producingCompany);
        void DeleteCompany(ProducingCompany producing);

        IQueryable<ProducingCompany> GetAllCompany();
          ProducingCompany GetCompany(int id);
        ProducingCompany GetCompanyName(string name);

    }
}
