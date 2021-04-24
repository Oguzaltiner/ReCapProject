using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in filter is null ? context.Cars : context.Cars.Where(filter)
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cl in context.Colors
                             on c.ColorId equals cl.ColorId

                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 ColorName = cl.ColorName,
                                 BrandName = b.BrandName,
                                 Description = c.Description,
                                 DailyPrice = c.DailyPrice,
                                 BrandId = c.BrandId,
                                 ColorId = c.ColorId

                             };
                return result.ToList();
            }

        }
        public List<CarDetailDto> GetCarsDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (ReCapContext reCapContext = new ReCapContext())
            {
                var result = from c in reCapContext.Cars
                             join b in reCapContext.Brands
                             on c.BrandId equals b.BrandId
                             join cl in reCapContext.Colors
                             on c.ColorId equals cl.ColorId
                             select new CarDetailDto
                             {
                                 CarId = c.Id,
                                 BrandId = b.BrandId,
                                 BrandName = b.BrandName,
                                 ColorId = cl.ColorId,
                                 ColorName = cl.ColorName
                             };

                return filter != null ? result.Where(filter).ToList() : result.ToList();
            }
        }
    }
}
