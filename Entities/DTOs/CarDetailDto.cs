using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CarDetailDto : IDto // IEntity deseydik sen bir veritabanı tablosusun demek olurdu fakat IDto ise birden fazla tablonun joini olabilir 
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int BrandId { get; set; }
        public string  BrandName { get; set; }
        public int ColorId { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }

    }
}
