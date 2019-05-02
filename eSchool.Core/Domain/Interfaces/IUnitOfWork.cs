using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace eSchool.Core.Domain
{
    public interface IUnitOfWork
    {
        Task<int> Commit();
    }
}
