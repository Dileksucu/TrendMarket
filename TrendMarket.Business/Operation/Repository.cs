using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendMarket.DataAccess.Context;

namespace TrendMarket.Business.Operation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly TrendMarketDbContext _context;
        //readonly --> sadece okunabilir , değiştirilemez 
        //private DbSet<T> _entities;

        public Repository(TrendMarketDbContext context)
        {
            this._context = context;
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }

        public T GetById(object id)
        {
           return _context.Find<T>(id);
            _context.SaveChanges();
        }

        public void Insert(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        //private DbSet<T> Entities
        //{
        //    get
        //    {
        //        if (_entities == null)
        //        {
        //            _entities = _context.Set<T>();
        //        }
        //        return _entities;
        //    }
        //}

        public IQueryable<T> Table => throw new NotImplementedException();
    }
}
