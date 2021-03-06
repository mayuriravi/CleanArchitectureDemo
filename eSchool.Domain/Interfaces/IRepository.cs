﻿using System.Collections.Generic;
using System.Text;

namespace eSchool.Domain
{
    public interface IRepository<T> where T : class 
    {

        //TODO: Generics missing
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id) ;
        List<T> GetAll() ;

    }
}
