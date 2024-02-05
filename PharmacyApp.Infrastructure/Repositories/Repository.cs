
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
        DbSet<T> _entity;
        public Repository(AppDbContext context)
        {
            _context = context;
            _entity = _context.Set<T>();
        }

        public T Add(T entity)
        {
          return  _entity.Add(entity).Entity;
        }

        public void Delete(T entity) 
        {
          var delete= _entity.Remove(entity);
            //if (entity != null)
            //{
            //    Save();
            //    _context.Entry(delete).State = EntityState.Detached;
            //}
        }

        public T DeleteById(T entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindAll(Expression<Func<T, bool>> criteria, int? take, int? skip, Expression<Func<T, object>> orderBy = null, string orderByDirection = "ASC")
        {
            IQueryable<T> query = _entity.Where(criteria);

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
            var all= _entity;
           // Save();
           // _context.Entry(_entity).State = EntityState.Detached;
            return all;
        }

        public T GetById(TId id)
        {
            var entity = _entity.Find(id);

            if (entity != null)
            {
                Save();
                _context.Entry(entity).State = EntityState.Detached;
            }

            return entity;

        }

        public T GetByName(string name)
        {
            return _context.Set<T>().Find(name);
        }

        public void Save()
        {

            _context.SaveChanges();
        }

        public T Update(T entity)
        {
           var up= _entity.Update(entity).Entity;
            Save();
            _context.Entry(entity).State =EntityState.Detached;
            return up;

        }
    }
}
