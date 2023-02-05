using Business.Concrete;
using Business.Constans;
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
        //CustomerTest();
        RentalTest();

    }

    private static void CustomerTest()
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        customerManager.Add(new Customer { UserId = 3, CustomerId = 4, CompanyName = "Kaçkar A.Ş" });
    }

    private static void RentalTest()
    {
        RentalManager rentalManager = new RentalManager(new EfRentalDal());
        var result = rentalManager.Add(new Rental
        {
            Id = 5,
            CarId = 2,
            CustomerId = 3,
            RentDate = new DateTime(2023, 01, 25),
            ReturnDate = new DateTime(2023, 01, 31)
        });

        Console.WriteLine(result.Message);
    }


}






