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
            GetAllCustomer();
        }

        private static void GetAllCustomer()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine("Şirket Adı:{0}-MüşteriId:{1}-KullanıcıId:{2}",
                item.CompanyName, item.CustomerId, item.UserId);
            }
        }

        private static void AddCustomer()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { CompanyName = "Volvo A.Ş", CustomerId = 1, UserId = 1 }
               );
            customerManager.Add(new Customer { CompanyName = "Güral A.Ş", CustomerId = 2, UserId = 2 }
              );
        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetail();
            foreach (var carDetail in result.Data)
            {
                Console.WriteLine(
                 "CarName : {0} -- BrandName : {1} -- ColorName : {2} -- DailyPrice : {3}",
                 carDetail.CarName, carDetail.BrandName, carDetail.ColorName, carDetail.DailyPrice
                 );
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var item in carManager.GetAll().Data)
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
