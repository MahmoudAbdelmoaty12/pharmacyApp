using pharmacyApp.models.Consts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace pharmacyApp.Application.Contract
{
    public interface IRepository<T,TId>
    {
    
        T GetById(TId id);
        T GetByName(string name);
        IQueryable<T> FindAll(Expression<Func<T, bool>> criteria, int? take, int? skip,
            Expression<Func<T, object>> orderBy = null, string orderByDirection = OrderBy.Ascending);
        IQueryable<T> GetAll();
        void Save();



    }
}
