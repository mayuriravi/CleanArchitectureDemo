using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using eSchool.Application;
using eSchool.Domain;

namespace eSchool.Persistence.Dapper
{
    public class StudentQueryService : IStudentQueryService
    {
        string connectionString;
        public StudentQueryService(string conString)
        {
            this.connectionString = conString;
        }
        public async Task<List<StudentsListViewModel>> GetStudents(StudentsListFilter filter)
        {
            List<StudentsListViewModel> students = null;
            string sql = @"
                    SELECT s.StudentID Id, s.Name, s.Email,s.StudentCode	                    
                    FROM dbo.Student a inner join dbo.Enrollments b on a.StudentId=b.StudentId
                    WHERE b.Name = @Course		                   
                    ORDER BY s.StudentID ASC";
            
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                var data = await connection
                   .QueryAsync<StudentsListViewModel>(sql, filter);
                students = data.ToList();                  
            };
            return students;
        }
    }
}