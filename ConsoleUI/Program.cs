using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarTest();
            //  CarDetailTest();
           // AddCustomer();
          
        }

     


        //private static void CarDetailTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    var result = carManager.GetCarDetail();
        //    foreach (var carDetail in result.Data)
        //    {
        //        Console.WriteLine(
        //         "CarName : {0} -- BrandName : {1} -- ColorName : {2} -- DailyPrice : {3}",
        //         carDetail.CarName, carDetail.BrandName, carDetail.ColorName, carDetail.DailyPrice
        //         );
        //    }
        //}

        //private static void CarTest()
        //{
        //    CarManager carManager = new CarManager(new InMemoryCarDal());
        //    foreach (var item in carManager.GetAll().Data)
        //    {
        //        Console.WriteLine(item.Description);
        //    }
        //}
    }
}
