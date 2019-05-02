using CleanArchitectureDemo.Infrastructure.SQLServer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eSchool.PersistenceGateway.SqlServer
{
    public class UnitOfWork
    {
        private readonly SqlDbContext dbContext;

        public UnitOfWork(SqlDbContext context)
        {
            dbContext = context;
        }
        public async Task<int> Commit()
        {
            return await dbContext.SaveChangesAsync();
        }
    }
}
