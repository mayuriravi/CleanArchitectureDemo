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
    public class CourseService : ICourseService
    {
        //TODO: add async get calls
        private readonly Infrastructure.SQLServer.SqlDbContext dbContext;

        public CourseService(Infrastructure.SQLServer.SqlDbContext context) 
        {
            dbContext = context;
        }
        public async Task<Course> GetByName(string name)
        {
            return dbContext.Courses.SingleOrDefault(m => m.Name == name);
           // return Mapper.Map<CourseEntity, Course>(data);
        }
       
    }
}
