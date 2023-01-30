using Business.Abstract;
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
            _carDal.Delete(car);
            Console.WriteLine("{0} isimli araba listeden kaldırılmıştır.",car.CarName);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public Car GetById(int id)
        {
            return _carDal.Get(c => c.CarId == id);
        }

        public List<Car> GetCarByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<CarDetailDto> GetCarDetailsDtos()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }

        public void Update(Car car)
        {
            if (car.Description.Length >=2 && car.DailyPrice>0)
            {
                Console.WriteLine("{0} isimli araba güncellenmiştir.",car.CarName);

            }
            else
            {
                Console.WriteLine("{0} isimli araba güncellenemedi! lütfen arabann ismini ve günlük fiyatını kontrol ediniz.",car.CarName);
            }
        }
         
    }
}

