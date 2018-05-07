﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class EFGenericRep<TEntity> : InterfaceGenericRep<TEntity> where TEntity : class
    {
        DbContext _context;//ссылка на контекст
        DbSet<TEntity> _dbSet;

        public EFGenericRep(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> Get()//получаем значения
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return _dbSet.AsNoTracking().Where(predicate).ToList();
        }
        public TEntity FindById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Create(TEntity item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }
        public void Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
        public void Remove(TEntity item)
        {
            _context.Entry(item).State = EntityState.Deleted;
            _dbSet.Remove(item);
            _context.SaveChanges();
        }
    }
}
//не удаляется, плохо работает связь!