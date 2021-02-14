using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface ICarService : IBaseService<Car>
    {
        IDataResult<List<CarDetailDto>> GetCarDetail();
    }
}
