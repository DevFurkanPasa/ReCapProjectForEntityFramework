using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfRepositoryBase<Car, OneCarPleaseContext>, ICarDal
    {
        public List<CarDetailDto> carDetails()
        {
            using (OneCarPleaseContext context = new OneCarPleaseContext())
            {
                var result = from color in context.Colors
                             from brand in context.Brands
                             join car in context.Cars
                             on color.Id equals car.ColorId
                             where brand.Id == car.BrandId
                             select new CarDetailDto
                             {
                                 BrandName = brand.BrandName,
                                 CarId = car.Id,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice
                             };

                return result.ToList();          
            }
        }
    }
}
