
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using eSchool.Domain;
using AutoMapper;

namespace eSchool.Persistence.EntityFramework
{
    public class StudentService : IStudentRepository
    {
        private readonly eSchoolSqlDbContext dbContext;
        public StudentService(eSchoolSqlDbContext context) 
        {
            dbContext = context;
        }
    public async Task<int> Add(Student entity)
        {
            //var data = Mapper.Map<Student, StudentEntity>(entity);
            //var e= await dbContext.Set<StudentEntity>().AddAsync(data); 
            var e= await dbContext.Set<Student>().AddAsync(entity);  
            return e.Entity.Id;
        }
       
        public async Task<Student> GetById(int id)
        {
            //var data = await dbContext.Set<StudentEntity>().FirstOrDefaultAsync(m => m.Id == id);
            //return Mapper.Map<StudentEntity, Student>(data);
            var data = await dbContext.Set<Student>().FirstOrDefaultAsync(m => m.Id == id);
            return data;
        }

        public async Task<List<Student>> GetAll()
        {
            //var data= await dbContext.Set<StudentEntity>().ToListAsync();
            //return Mapper.Map<List<StudentEntity>, List<Student>>(data);
            return await dbContext.Set<Student>().ToListAsync();
            
        }

        public void Delete(Student entity)
        {
            //var data = Mapper.Map<Student, StudentEntity>(entity);
            //dbContext.Set<Student>().Remove(entity);
            dbContext.Set<Student>().Remove(entity);
        }

        public  void Update(Student entity)
        {
            //var data = Mapper.Map<Student, StudentEntity>(entity);
            //dbContext.Entry(entity).State = EntityState.Modified;
           dbContext.Entry(entity).State = EntityState.Modified;
        }



    }
}
