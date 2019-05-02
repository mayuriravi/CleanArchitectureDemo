using System.Collections.Generic;
using System.Text;

namespace eSchool.Core.Domain
{
    public interface IService<T> where T : class 
    {

        //TODO: Generics missing
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id) ;
        List<T> GetAll() ;

    }
}
