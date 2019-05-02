using CleanArchitectureDemo.Core;
using CleanArchitectureDemo.Core.Domain;
using CleanArchitectureDemo.Core.Interfaces;
using CleanArchitectureDemo.Infrastructure.SQLServer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CleanArchitectureDemo.Infrastructure.SQLServer.Entities;

namespace CleanArchitectureDemo.Gateway.SqlServer
{
    public class StudentService : IStudentService
    {
        //TODO: add async get calls
        private readonly SqlDbContext dbContext;
        public async Task<int> Add(Student entity)
        {           
           // var data = Mapper.Map<Student, StudentEntity>(entity);
            var e= await dbContext.Set<Student>().AddAsync(entity);            
            return e.Entity.Id;
        }
       
        public async Task<Student> GetById(int id)
        {
            var data = await dbContext.Set<Student>().FirstOrDefaultAsync(m => m.Id == id);
            //return Mapper.Map<StudentEntity, Student>(data);
            return data;
        }

        public async Task<List<Student>> GetAll()
        {
            return await dbContext.Set<Student>().ToListAsync();
            //return Mapper.Map<List<StudentEntity>, List<Student>>(data);
        }

        public async void Delete(Student entity)
        {
            //var data = Mapper.Map<Student, StudentEntity>(entity);
            dbContext.Set<Student>().Remove(entity);            
        }

        public async void Update(Student entity)
        {
            //var data = Mapper.Map<Student, StudentEntity>(entity);
            dbContext.Entry(entity).State = EntityState.Modified;           
        }



    }
}
