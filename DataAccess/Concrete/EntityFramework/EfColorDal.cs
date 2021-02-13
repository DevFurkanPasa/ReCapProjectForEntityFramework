using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public class EfColorDal : EfRepositoryBase<Color,OneCarPleaseContext> ,IColorDal
    {
    }
}
