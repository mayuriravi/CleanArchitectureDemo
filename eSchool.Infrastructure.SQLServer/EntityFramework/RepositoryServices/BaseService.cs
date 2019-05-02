using AutoMapper;
using eSchool.Domain;
using eSchool.Persistence.EntityFramework.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace eSchool.Persistence.EntityFramework
{
    public class BaseService<T, TEntity> where T: class where TEntity :IdEntity
    {
        private readonly DbContext dbContext;

        public BaseService(DbContext context)
        {
            dbContext = context;
        }       

        public T Add(T entity) 
        {
            var data = Mapper.Map<T,TEntity>(entity);
            dbContext.Set<TEntity>().Add(data);
            return entity;
        }

        public T GetById(int id) 
        {
            var data = dbContext.Set<TEntity>().SingleOrDefault(m => m.Id == id);
            return Mapper.Map<TEntity,T>(data);
        }
        public List<T> GetAll() 
        {
            var data = dbContext.Set<TEntity>().ToList();
            return Mapper.Map<List<TEntity>, List<T>>(data);
        }

        public void Delete(T entity) 
        {
            var data = Mapper.Map<T, TEntity>(entity);
            dbContext.Set<TEntity>().Remove(data);
        }

        public void Update(T entity)
        {
            var data = Mapper.Map<T, TEntity>(entity);
            dbContext.Entry(data).State = EntityState.Modified;
        }
       

        
    }
}
