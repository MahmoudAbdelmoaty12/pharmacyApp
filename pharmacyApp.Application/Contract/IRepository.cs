using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacyApp.Application.Contract
{
    public interface IRepository<T,TId>
    {
    
        T GetById(TId id);
        T GetByName(string name);
        T Add(T entity);
        T Update(T entity);
        T DeleteById(T entity);
        void Save();



    }
}
