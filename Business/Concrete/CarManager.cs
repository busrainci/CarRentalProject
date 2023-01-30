﻿using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Absract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice>0)
            {
                _carDal.Add(car);
                Console.WriteLine("{0} isimli araba listeye eklenmiştir.",car.CarName);
            }
            else
            {
                Console.WriteLine("araç eklenmedi,lütfen araç ismini ve günlük fiyatını kontrol ediniz.");
            }
            _carDal.Add(car);
            return new SuccessDataResult<Car>(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _carDal.Delete(car);
                Console.WriteLine(Messages.CarDeleted);
            }
            else
            {
                Console.WriteLine(Messages.CarNotDeleted);
            }
            return new ErrorDataResult<Car>(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 14)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }
        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max));
        }

        public IDataResult<Car>GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == id));
        }

        public IDataResult<List<Car>>GetCarByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<CarDetailDto>> GetCarDetailsDtos()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
        }

        public IDataResult<List<Car>>GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId));
        }

        public IResult Update(Car car)
        {
            if (car.Description.Length >=2 && car.DailyPrice>0)
            {
                Console.WriteLine(car.CarName,Messages.CarUpdate);

            }
            else
            {
                Console.WriteLine(car.CarName,Messages.CarNotUpdate);
            }
            _carDal.Update(car);
            return new ErrorResult(Messages.CarNotUpdate);
        }
         
    }
}

