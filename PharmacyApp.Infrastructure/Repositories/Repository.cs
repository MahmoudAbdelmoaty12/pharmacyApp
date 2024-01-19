<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using pharmacyApp.Application.Contract;

namespace PharmacyApp.Infrastructure.Repositories
{
   public  class Repository:IRepository<T,TId>
    {




=======
﻿using Microsoft.EntityFrameworkCore;
using pharmacyApp.Application.Contract;
using pharmacyApp.models.Consts;
using PharmacyApp.Context.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp.Infrastructure.Repositories
{
    public class Repository<T, TId> : IRepository<T, TId> where T : class
    {
        protected AppDbContext _context;
        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<T> FindAll(Expression<Func<T, bool>> criteria, int? take, int? skip, Expression<Func<T, object>> orderBy = null, string orderByDirection = "ASC")
        {
            IQueryable<T> query = _context.Set<T>().Where(criteria);

            if (skip.HasValue)
                query = query.Skip(skip.Value);

            if (take.HasValue)
                query = query.Take(take.Value);

            if (orderBy != null)
            {
                if (orderByDirection == OrderBy.Ascending)
                    query = query.OrderBy(orderBy);
                else
                    query = query.OrderByDescending(orderBy);
            }

            return query;
        }

        

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetById(TId id)
        {
            return _context.Set<T>().Find(id);
        }

        public T GetByName(string name)
        {
            return _context.Set<T>().Find(name);
        }

        public void Save()
        {

            _context.SaveChanges();
        }
>>>>>>> b8422d34d9c11c9856b35ae6a43a29485444e436
    }
}
