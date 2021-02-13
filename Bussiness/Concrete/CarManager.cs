using Bussiness.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car entity)
        {
            _carDal.Add(entity);
        }

        public void Delete(Car entity)
        {
            _carDal.Delete(entity);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetCarDetail()
        {
            return _carDal.carDetails();
        }

        public void Update(Car entity)
        {
            _carDal.Update(entity);
        }
    }
}
