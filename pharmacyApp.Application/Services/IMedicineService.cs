using pharmacyApp.models.Models;
using System.Linq.Expressions;

namespace pharmacyApp.Application.Services
{
    public interface IMedicineService
    {
        Medicincs AddMedicine(Medicincs medicincs);
        void DeleteMedicine(Medicincs order);
        IQueryable<Medicincs> FindAllMedicins(Expression<Func<Medicincs, bool>> criteria, int? take, int? skip, Expression<Func<Medicincs, object>> orderBy = null, string orderByDirection = "ASC");
        IQueryable<Medicincs> GetAllMedicins();
        Medicincs GetMedicine(int id);
        Medicincs GetMedicineName(string name);
        Medicincs UpdateMedicine(Medicincs order);
        public bool IsMedicineValid(Medicincs medicincs);
    }
}