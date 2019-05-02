using AutoMapper;
using CleanArchitectureDemo.Core;
using CleanArchitectureDemo.Core.Common;
using CleanArchitectureDemo.Core.Interfaces;
using CleanArchitectureDemo.Infrastructure.SQLServer;
using CleanArchitectureDemo.Infrastructure.SQLServer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CleanArchitectureDemo.Gateway.SqlServer
{
    public class BaseService<T, TEntity> where T: class where TEntity :Entity
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
