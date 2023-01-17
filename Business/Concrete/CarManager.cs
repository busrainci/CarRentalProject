using Business.Abstract;
using DataAccess.Absract;
using Entities.Concrete;
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

       

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

      ////  public List<Car> GetByCarName(string min, string max)
      //  {
      //      return _carDal.GetAll(c => c.CarName >= min && c.CarName <= max);
      //  }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);
        }

        public List<Car> GetCarByBrandId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }

        public List<Car> GetCarByColorId(int colorId)
        {
            return _carDal.GetAll(c => c.ColorId == colorId);
        }
    }
}

