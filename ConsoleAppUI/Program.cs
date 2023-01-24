using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNet.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Umbraco.Core.Models.Membership;
using EfCarDal = DataAccess.Concrete.EntityFramework.EfCarDal;

public class Program
{
    public static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new EfCarDal());
        Console.WriteLine("*******ARAÇ LİSTELEME*******");

        foreach (var car in carManager.GetCarDetailsDtos())
        {
            Console.WriteLine("Marka : " + car.BrandName);
            Console.WriteLine("Renk : " + car.ColorName);
            Console.WriteLine("Günlük fiyat : " + car.DailyPrice);

        }

        ReCarContext ctx = new ReCarContext();
        List<Car> cars = ctx.Cars.Include(c=>c.Brand).Include(c=>c.Color).ToList();
        foreach (var myCar in cars)
        {
            Console.WriteLine(myCar.CarId + " " + myCar.CarName + " renk: " +myCar.Color.ColorName + " brand: " + myCar.Brand.BrandName  );
        }




        //EfCarDal inMemoryCar = new EfCarDal();
        //inMemoryCar.Add(new Car { Id = 7, ColorId = 5, BrandId = 2, ModelYear = "2021", DailyPrice = 350000, Description = "Skoda superb 2.0" });

        //foreach (var car in inMemoryCar.GetAll())
        //{
        //    Console.WriteLine(car.Description);
        //}
        //Console.WriteLine();
        //Console.WriteLine("-------------");
        //Console.WriteLine();





        // CarTest();

    }

    //private static void CategoryTest()
    //{
    //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    //    foreach (var category in categoryManager.GetAll())
    //    {
    //        Console.WriteLine(category.CategoryName);
    //    }
    //}

    ////private static void CarTest()
    //{
    //    //ReCarContext context = new ReCarContext();
    //    //var Cars = context.Cars.ToList();
    //    //foreach (var c in Cars) 
    //    // {
    //    //    Console.WriteLine(c.CarId);

    //    //}

    //    //CarManager carManager = new CarManager(new EfCarDal());

    //    //foreach (var car in carManager.GetCarDetails())
    //    //{
    //    //    Console.WriteLine(car.CarName + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
    //    //}

    //    //  foreach (var car in carManager.GetAll())
    //    //  {
    //    //      if (car.DailyPrice > 0 && car.CarName.Length > 2)
    //    //      {
    //    //          Console.WriteLine(car.CarName);
    //    //      }
    //    //      else
    //    //      {
    //    //          Console.WriteLine("ürün bulunamadı.");
    //    //      }


    //    //  }
    //}
    
    static BrandManager GetByBrandId()
    {
        Console.WriteLine("******Marka Id sine göre Marka ismi gösterme********");
        BrandManager brandManager = new BrandManager(new EfBrandDal());
        foreach (var brand in brandManager.GetByBrandId(2))
        {
            Console.WriteLine("Brand Id'si 2 olan aracın marka ismi : " + brand.BrandName);
        }
        return brandManager;
    }
    static void Update(BrandManager brandManager)
    {
        Console.WriteLine("******Marka Güncelleme*******");
        brandManager.Update(new Brand { BrandId = 3005, BrandName = "Audi" });

    }
    static void Add(BrandManager brandManager)
    {
        Console.WriteLine("*******Marka Ekleme******");
        brandManager.Add(new Brand { BrandName = "Hundai", BrandId = 120 });

    }
    static void Delete(BrandManager brandManager)
    {
        Console.WriteLine("*******Marka Silme********");
        brandManager.Delete(new Brand { BrandName = "Toyota" });
    }








}
