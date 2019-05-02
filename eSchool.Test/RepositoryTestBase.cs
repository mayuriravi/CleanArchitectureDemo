using eSchool.Domain;
using eSchool.Persistence.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace eSchool.Tests
{
    public class RepositoryTestBase 
    {
        protected IUnitOfWork proxy;
        public void Initilalize()
        {
            proxy = new UnitOfWork(MockDbContext.Object);
        }

        private eSchoolMockDbContext mockDbContext = new eSchoolMockDbContext();
        public eSchoolMockDbContext MockDbContext
        {
            get
            {
                return mockDbContext;
            }
        }

    }
}
