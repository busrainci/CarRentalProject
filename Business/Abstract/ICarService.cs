﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarByBrandId(int brandId);
        List<Car> GetCarByColorId(int colorId);
        List<Car> GetByDailyPrice(decimal min, decimal max);
        //List<Car> GetByCarName(string min, string max);

    }
}
