using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IBaseService<T>
    {
        List<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
