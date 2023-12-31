﻿using Product.Core.Common;
using Products.Core.Contex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Repositories
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : class, IEntity<TKey>
        where TKey : struct
    {
        protected ProductContex ctx;

        public Repository(ProductContex ctx)
        {
            this.ctx = ctx;
        }
        public void Create(TEntity entity)
        {
            ctx.Set<TEntity>().Add(entity);
            Save();
        }

        public void Delete(TEntity entity)
        {
            ctx.Set<TEntity>().Remove(entity);
            Save();
        }

        public TEntity Get(TKey key)
        {
            return ctx.Set<TEntity>().Find(key);
        }

        public IEnumerable<TEntity> GetAll() => ctx.Set<TEntity>().ToList();

        public void Save()
        {
            ctx.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            ctx.Set<TEntity>().Update(entity);
            Save();
        }
    }
}
