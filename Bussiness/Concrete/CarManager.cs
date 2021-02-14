using Bussiness.Abstract;
using Bussiness.Constans;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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

        public IResult Add(Car entity)
        {
            _carDal.Add(entity);
            return new SuccessResult(Messages.AddedCar);
        }

        public IResult Delete(Car entity)
        {
            _carDal.Delete(entity);
            return new SuccessResult(Messages.DeletedCar);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<CarDetailDto>> GetCarDetail()
        {
            return new DataResult<List<CarDetailDto>>(_carDal.carDetails(),true);
        }

        public List<CarDetailDto> GetCarDetail1()
        {            
            return _carDal.carDetails();
        }

        public IResult Update(Car entity)
        {
            return new SuccessResult(Messages.UpdatedCar);
        }
    }
}
