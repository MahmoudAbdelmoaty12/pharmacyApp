using pharmacyApp.Application.Contract;
using pharmacyApp.models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace pharmacyApp.Application.Services
{
    public class MedicineService : IMedicineService
    {
        IMedicincs _medicincs;

        public MedicineService(IMedicincs medicincs)
        {
            _medicincs = medicincs;
        }

        public Medicincs AddMedicine(Medicincs medicincs)
        {
         
            var add = _medicincs.Add(medicincs);
            _medicincs.Save();
            return add;
        }
        public Medicincs GetMedicine(int id)
        {
            return _medicincs.GetById(id);
        }
        public IQueryable<Medicincs> GetAllMedicins()
        {
            return _medicincs.GetAll();
        }

        public void DeleteMedicine(Medicincs order)
        {
            _medicincs.Delete(order);
            _medicincs.Save();
        }

        public Medicincs UpdateMedicine(Medicincs order)
        {
            var delete = _medicincs.Update(order);
            _medicincs.Save();
            return delete;
        }
        public Medicincs GetMedicineName(string name)
        {
            return _medicincs.GetByName(name);
        }
        public IQueryable<Medicincs> FindAllMedicins(Expression<Func<Medicincs, bool>> criteria, int? take, int? skip, Expression<Func<Medicincs, object>> orderBy = null, string orderByDirection = "ASC")
        {
            return _medicincs.FindAll(criteria, take, skip, orderBy, orderByDirection);
        }
        public ProducingCompany GetCompanyName(int medicineId)
        {
            return _medicincs.GetProducingCompany(medicineId);
        }

    }
}
