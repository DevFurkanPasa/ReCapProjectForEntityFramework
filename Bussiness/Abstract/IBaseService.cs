using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Bussiness.Abstract
{
    public interface IBaseService<T>
    {
        IDataResult<List<T>> GetAll();
        IResult Add(T entity);
        IResult Update(T entity);
        IResult Delete(T entity);

    }
}
