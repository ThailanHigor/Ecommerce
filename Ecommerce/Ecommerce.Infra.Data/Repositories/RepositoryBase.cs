﻿using Ecommerce.Domain.Interfaces.Repositories;
using Ecommerce.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ecommerce.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected EcommerceContext db = new EcommerceContext();

        public void Add(TEntity obj)
        {
            db.Set<TEntity>().Add(obj);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return db.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            db.Set<TEntity>().Remove(obj);
            db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
