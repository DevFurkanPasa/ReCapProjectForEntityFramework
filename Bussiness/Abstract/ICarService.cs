using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
    public interface ICarService : IBaseService<Car>
    {
        List<CarDetailDto> GetCarDetail();
    }
}
