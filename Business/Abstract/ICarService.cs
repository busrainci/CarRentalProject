using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {   //ctrl + k + c Yorum satırı kısayolu

        //List<Car> GetAll();
        //List<Car> GetCarsByBrandId(int brandId);
        //List<Car> GetCarsByColorId(int colorId);
        //List<Car> GetByDailyPrice(decimal min, decimal max);
        //List<CarDetailDto> GetCarDetailsDtos();

        //void Add(Car car);
        //void Update(Car car);
        //void Delete(Car car);   
        //Car GetById(int id);

        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<List<CarDetailDto>> GetCarDetailsDtos();

        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<Car> GetById(int id);





    }
}
