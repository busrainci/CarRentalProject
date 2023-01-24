using Core.DataAccess.EntityFramework;
using DataAccess.Absract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepoSitoryBase<Car, ReCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCarContext context = new ReCarContext())
            {
                var result = from car in context.Cars
                             join c in context.Colors on car.ColorId equals c.ColorId
                             join b in context.Brands on car.BrandId equals b.BrandId 
                             select new CarDetailDto
                             {   
                                 CarId = car.CarId,
                                 CarName = car.CarName,
                                 ColorName = c.ColorName,                                
                                 BrandName = b.BrandName, 
                                 DailyPrice = car.DailyPrice!.Value
                             };

                return result.ToList();
               
            }
        }
    }
}
