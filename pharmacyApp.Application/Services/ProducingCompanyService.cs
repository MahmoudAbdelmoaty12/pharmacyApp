using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pharmacyApp.Application.Contract;
using pharmacyApp.models.Models;

namespace pharmacyApp.Application.Services
{
    public class ProducingCompanyService : IProducingCompanyService
    {
        IProducingCompany _ProducingCompany;
        public ProducingCompanyService(IProducingCompany IproducingCompany)
        {
            _ProducingCompany = IproducingCompany;
        }
        public ProducingCompany AddCompany(ProducingCompany producingCompany)
        {
          var add=_ProducingCompany.Add(producingCompany);
            _ProducingCompany.Save();
            return add;
            
        }

        public void DeleteCompany(ProducingCompany producing)
        {
            _ProducingCompany.Delete(producing);
            _ProducingCompany.Save();
            
        }

        public IQueryable<ProducingCompany> GetAllCompany()
        {
          return  _ProducingCompany.GetAll();
        }

        public ProducingCompany GetCompany(int id)
        {
          return  _ProducingCompany.GetById(id);
        }

        public ProducingCompany GetCompanyName(string name)
        {
            return _ProducingCompany.GetByName(name);
        }

        public ProducingCompany UpdateCompany(ProducingCompany producingCompany)
        {
          var update=  _ProducingCompany.Update(producingCompany);
            _ProducingCompany.Save();
            return update;
        }
    }
}
