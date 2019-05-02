using eSchool.Persistence.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace eSchool.Tests
{
    public class eSchoolMockDbContext : Mock<eSchoolSqlDbContext>
    {
        public eSchoolMockDbContext()
        {
            //Configure();
        }

        public MockDbSet<T> SetupMockDbSet<T>(Expression<Func<eSchoolSqlDbContext, DbSet<T>>> expression, MockDbSet<T> setToSetup) where T : class
        {
            Setup(expression).Returns(setToSetup.Object);
            Setup(m => m.Set<T>()).Returns(setToSetup.Object);
            return setToSetup;
        }

    }
}