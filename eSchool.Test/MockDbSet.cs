using Moq;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace eSchool.Tests
{
    public class MockDbSet<TEntity> : Mock<DbSet<TEntity>> where TEntity : class
    {
        private List<TEntity> _data;

        public MockDbSet(List<TEntity> data)
        {
            _data = data;
            As<IQueryable<TEntity>>().Setup(m => m.Provider).Returns(_data.AsQueryable().Provider);
            As<IQueryable<TEntity>>().Setup(m => m.Expression).Returns(_data.AsQueryable().Expression);
            As<IQueryable<TEntity>>().Setup(m => m.ElementType).Returns(_data.AsQueryable().ElementType);
            As<IQueryable<TEntity>>().Setup(m => m.GetEnumerator()).Returns(_data.AsQueryable().GetEnumerator());

        }


    }
}
